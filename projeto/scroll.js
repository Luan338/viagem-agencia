function animacaoScroll(){
    const sections = document.querySelectorAll('.js-scroll');
    
    if(sections.length){
        const windowMetade = window.innerHeight * 0.7;

        function animaScroll(){
            sections.forEach((e) => {
                const sectionTop = e.getBoundingClientRect().top;
                const isSectionVisible = (sectionTop - windowMetade) < 0;

                if(isSectionVisible){
                    e.classList.add('ativo');
                }

            })
        }
        animaScroll();
        window.addEventListener('scroll', animaScroll);
    }
}
animacaoScroll();



function initScrollSuave(){

    const linksInternos = document.querySelectorAll('.js-menu a[href^="#"');
    
    function scrollToSection(e){
        e.preventDefault();

        const href = e.currentTarget.getAttribute('href');
        const section = document.querySelector(href);
        
        const topo = section.offsetTop;
    
        section.scrollIntoView({
            behavior: 'smooth',
            block: 'start'
        });
    }
    
    linksInternos.forEach((link) => {
        link.addEventListener('click', scrollToSection);
    })
    }
    initScrollSuave();  