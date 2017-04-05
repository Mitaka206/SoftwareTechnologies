const Article = require('mongoose').model('Article');

module.exports = {
    createGet:(req, res) => {
        res.render('article/create');
    },
    createPost:(req, res) => {
        let articleParts = req.body;

        let errorMsg = '';

        if (!req.isAuthenticated()){
            errorMsg = 'Sorry! Pleace logged in!';
        }else if(!articleParts.title){
            errorMsg = 'Write Title!';
        }else if(!articleParts.content){
            errorMsg = 'Write Content!';
        }

        if (errorMsg){
            res.render('article/create', {
                error: errorMsg
            });


        }else {

            let userId = req.user.id;
            articleParts.author = userId;

            Article.create(articleParts).then(artcle => {
                req.user.articles.push(artcle.id);
                req.user.save(err => {
                    if (err){
                        res.render('article/create', {
                            error: err.message
                        });
                    }else {
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


    }
};
