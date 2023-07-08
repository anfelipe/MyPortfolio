const scrollHandler = () => {

    let menu = document.getElementById('main');

    let A = document.getElementById('header');
    //let B = document.getElementById('B')
    //let C = document.getElementById('C')

    let pos_menu = window.pageYOffset + menu.offsetHeight;

    let pos_A = A.offsetTop + A.offsetHeight;
    //let pos_B = B.offsetTop + B.offsetHeight
    //let pos_C = C.offsetTop + C.offsetHeight
    
    let distance_A = pos_A - pos_menu;
    //let distance_B = pos_B - pos_menu
    //let distance_C = pos_C - pos_menu

    let min = Math.min(...[distance_A].filter(num => num > 0));

    //document.querySelectorAll('.Menu .Item')[0].classList.remove('Highlight')
    //document.querySelectorAll('.Menu .Item')[1].classList.remove('Highlight')
    //document.querySelectorAll('.Menu .Item')[2].classList.remove('Highlight')

    if (min === distance_A) console.log(min); //document.querySelectorAll('.Menu .Item')[0].classList.add('Highlight')
    //if(min === distance_B) document.querySelectorAll('.Menu .Item')[1].classList.add('Highlight')
    //if(min === distance_C) document.querySelectorAll('.Menu .Item')[2].classList.add('Highlight')

}

window.addEventListener('scroll', scrollHandler);