const scrollHandler = () => {

    /*seccions*/
    let home = document.getElementById('home');
    let header = document.getElementById('header');
    let about = document.getElementById('about');
    let portfolio = document.getElementById('portfolio');

    if (home.offsetTop) return;

    /*links*/
    let hHome = document.getElementById('hhome');
    let hAbout = document.getElementById('habout');
    let hPortfolio = document.getElementById('hportfolio');
    let hContact = document.getElementById('hcontact');

    if (home != null && home.offsetTop) return;

    /*positions*/
    var doc = document.documentElement;
    var scroll = (window.pageYOffset || doc.scrollTop) - (doc.clientTop || 0);

    let pos_home = home.offsetTop + home.offsetHeight;
    let pos_about = about.offsetTop + about.offsetHeight;
    let pos_portfolio = portfolio.offsetTop + portfolio.offsetHeight;

    /*color*/
    let selectColor = 'rgb(103, 130, 134)';
    let whiteColor = 'white';
    header.style.background = "transparent";

    if (scroll > pos_home) {
        header.style.background = "black";
    }   

    hHome.style.color = whiteColor;
    hAbout.style.color = whiteColor;
    hPortfolio.style.color = whiteColor;
    hContact.style.color = whiteColor;    

    if (window.innerHeight + window.pageYOffset > pos_portfolio) {
        hContact.style.color = selectColor;
    } else if (scroll >= pos_about) {
        hPortfolio.style.color = selectColor;
    } else if (scroll >= pos_home) {
        hAbout.style.color = selectColor;
    } else {
        hHome.style.color = selectColor;
    }    
}

window.addEventListener('scroll', scrollHandler);