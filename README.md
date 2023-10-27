# BackendProject
https://preview.themeforest.ne-> Full Dynamic 
1.Home,About,Shop(ShopSingle),Cart,Login,Register,Contact,Blog(Detail),Checkout
2.Yeni dizayn Admin Panel
3.User sistemi(Role:Admin,User)
4.Layihede partialview ve viewcomponentlerden istifade.
5.Servise cixartma mentigi,Admin panelde butun controller icinde olan actionlarda yazilan codlar service-lere chixardin,mes:
ICategoryService (getOne,getAll,update,create ve.s) CategoryService,sonra inject edib action ichinde istifade edeceksiz(Detail action icinde getOne ve.s cagirilacaq ,controller ichi seliqeli olacaq),eyer method async bir ish gorecekse adina diqqet edin (getOneAsync) kimi olsun.
6.Search,
7.Email Confirmation,ForgotPassword ve en az bir External Login, optional (Google,Facebook),TwoFactor olsun.
8.Pagination,Subscribe olma,en az 3 entity seed data.
9.Layihe ecommerce-di satish yazilmalidir.admin terefinden butun satishlar gorulmeli(admin panelde),mehsul elave edilende abune olanlara email getsin (link) click olunanda gelsin hemin mehsulun detail-a.
10.SelfJoin Category olacaq (yeni tek bir category table olacaq oz ozu ile self  join olacaq, 2 nested category bes edir esas ve child
11.Hergun commit, migration ve umumiyyetle adlandirmalara diqqet
