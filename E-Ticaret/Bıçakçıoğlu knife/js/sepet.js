document.addEventListener("DOMContentLoaded", function () {
    const satinalBtns = document.querySelectorAll(".sepet_bt");

    satinalBtns.forEach((btn) => {

        btn.addEventListener("click", function () {

            const boxMainDiv = btn.closest(".box_main");
            const urunAdiH4 = boxMainDiv.querySelector(".shirt_text");
            const urunAdi = urunAdiH4.textContent;



            const sepetMesaji = `${urunAdi} başarıyla sepete eklenmiştir.`;


            Toastify({
                text: sepetMesaji,
                duration: 3000,
                close: true,
                gravity: "top",
                position: "center",
            }).showToast();
        });
    });
});
