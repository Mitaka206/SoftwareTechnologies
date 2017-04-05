const Article = require('mongoose').model('Article');

function validateArticle(articleArgs, req) {
    let errorMsg = '';

    if (!req.isAuthenticated()){
        errorMsg = 'Sorry! Pleace logged in!';
    }else if(!articleArgs.title){
        errorMsg = 'Write Title!';
    }else if(!articleArgs.content){
        errorMsg = 'Write Content!';
    }
    return errorMsg;
}

module.exports = {
    createGet:(req, res) => {
        res.render('article/create');
    },
    createPost:(req, res) => {
        let articleArgs = req.body;

        let errorMsg = validateArticle(articleArgs, req);

        if (errorMsg){
            res.render('article/create', {
                error: errorMsg
            });


        }else {

            let userId = req.user.id;
            articleArgs.author = userId;

            Article.create(articleArgs).then(artcle => {
                req.user.articles.push(artcle.id);
                req.user.save(err => {
                    if (err){
                        res.render('article/create', {
                            error: err.message
                        });
                    } else {
                        res.redirect('/')
                    }
                });
            });
        }

    },

    detailsGet:(req, res) => {
        let id = req.params.id;

        Article.findById(id).populate('author').then(article => {
            res.render('article/details', article);
        })

    },

    editGet:(req, res) => {
        let id = req.params.id;

        if(!req.isAuthenticated()){
            let returnUrl = `/article/edit/${id}`;
            req.session.returnUrl = returnUrl;

            res.redirect('/user/login');
            return;
        }

        Article.findById(id).then(article => {
            if (req.user === undefined || !req.user.isAuthor(article) || !req.user.isInRole(('Admin'))){
                res.render('home/index', {error: 'You cannot edit this article'})
                return;
            }

            res.render('article/edit', article);
        })
    },
    editPost:(req, res) => {
        let id = req.params.id;

        let articleArgs = req.body;

        let errorMsg = validateArticle(articleArgs, req);

        if (errorMsg){
            res.render('article/edit', {error: errorMsg});
            return;
        }
        Article.update({_id: id}, {$set: {
            title: articleArgs.title,
            content: articleArgs.content}})
                .then(err => {
               res.redirect(`/article/details/${id}`);
            });

    },

    deleteGet: (req, res) => {
        let id = req.params.id;

        if(!req.isAuthenticated()){
            let returnUrl = `/article/delete/${id}`;
            req.session.returnUrl = returnUrl;

            res.redirect('/user/login');
            return;
        }

        Article.findById(id).then(article => {
            if (req.user === undefined || !req.user.isAuthor(article) || !req.user.isInRole(('Admin'))){
                res.render('home/index', {error: 'You cannot edit this article'})
                return;
            }

            res.render('article/delete', article);
        })
    },
    deletePost: (req, res) => {
        let id = req.params.id;

        Article.findByIdAndRemove(id).then(article => {
            let index = req.user.articles.indexOf(article.id);
            req.user.articles.splice(index, 1);
            req.user.save(err => {
                if (err){
                    res.render('/', { error: err.message });
                } else {
                    res.redirect('/')
                }
            });
        });
    }
};
