feather.replace();
const headerLinks = document.querySelectorAll('.header-link');
const backBtns = document.querySelectorAll('.back-btn');
const closeMenu = document.querySelector('.close-menu');
const dropdowns = document.querySelectorAll('.dropdown');
const menuBar = document.querySelector('.menubar');
const menuSideBar = document.querySelector('.bottom-nav');
const blackAreaMenu = document.querySelector('.black-area');

headerLinks.forEach((link , i) =>{
    link.addEventListener('click',function(){
        const dropdown = link.parentNode.querySelector('.dropdown');
        if(dropdown != undefined){
            dropdown.style.left = '20%';
        }
    });
});

backBtns.forEach((btn) =>{
    btn.addEventListener('click',function(){
        const parent = btn.parentNode;
        parent.style.left = '100%';
    });
});

closeMenu.addEventListener('click',function(){
    menuSideBar.style.left = "100%";
    blackAreaMenu.style.opacity = 0;
});

menuBar.addEventListener('click',function(){
    menuSideBar.style.left = 0;
    blackAreaMenu.style.opacity = 1;
});
blackAreaMenu.addEventListener('click',function(){
    dropdowns.forEach(drop => drop.style.left = '100%');
    menuSideBar.style.left = "100%"; 
    blackAreaMenu.style.opacity = 0;   
});