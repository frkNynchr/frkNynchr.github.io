const menu = document.getElementById("");


function scroolStyle(id) {
    if (id === "href1") {
        const menu = document.getElementById("menu");
        menu.scrollIntoView({
            block: 'center',
        });
    }
    else if (id === "href2") {
        const hakkımda = document.getElementById("hakkımda");
        hakkımda.scrollIntoView({
            block: 'center',
        });
    }
    else if (id === "href3") {
        const sertifika = document.getElementById("sertifika");
        sertifika.scrollIntoView({
            block: 'center',
        });
    }
    else if (id === "href4") {
        const projeler = document.getElementById("projeler");
        projeler.scrollIntoView({
            block: 'center',
        });
    }
    else if (id === "href5") {
        const iletişim = document.getElementById("iletişim");
        iletişim.scrollIntoView({
            block: 'center',
        });
    }

}