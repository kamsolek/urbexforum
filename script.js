document.addEventListener("DOMContentLoaded", function () {
    const loginModal = document.getElementById("loginModal");
    const loginBtn = document.getElementById("login-btn");
    const closeModal = document.querySelector(".login-close");

    const loginForm = document.getElementById("loginForm");
    const registerForm = document.getElementById("registerForm");

    const showRegister = document.getElementById("showRegister");
    const showLogin = document.getElementById("showLogin");

    loginBtn.addEventListener("click", function () {
        loginModal.style.display = "flex";
        loginForm.style.display = "block";
        registerForm.style.display = "none";
    });

    closeModal.addEventListener("click", function () {
        loginModal.style.display = "none";
    });

    showRegister.addEventListener("click", function (event) {
        event.preventDefault();
        loginForm.style.display = "none"; // Ukrywa formularz logowania
        registerForm.style.display = "block"; // Pokazuje formularz rejestracji
    });

    showLogin.addEventListener("click", function (event) {
        event.preventDefault();
        registerForm.style.display = "none"; // Ukrywa formularz rejestracji
        loginForm.style.display = "block"; // Pokazuje formularz logowania
    });

    // Zamknięcie modalu po kliknięciu poza nim
    window.addEventListener("click", function (event) {
        if (event.target === loginModal) {
            loginModal.style.display = "none";
        }
    });



    // Dodanie przykładowych kafelków postów
    const forumContainer = document.querySelector(".forum");
    for (let i = 1; i <= 30; i++) {
        let post = document.createElement("div");
        post.classList.add("post-tile");
        post.innerHTML = `
            <div class="photo-placeholder"></div>
            <h3>Post ${i}</h3>
        `;
        forumContainer.appendChild(post);
    }

    // Zegar w stopce
    function updateClock() {
        const now = new Date();
        const timeString = now.toLocaleTimeString();
        document.getElementById("clock").textContent = timeString;
    }
    setInterval(updateClock, 1000);
    updateClock();
});
document.addEventListener("DOMContentLoaded", function () {
    const forumContainer = document.querySelector(".forum");
    const postModal = document.getElementById("postModal");
    const closeModal = postModal.querySelector(".close");
    const modalImage = document.getElementById("modalImage");
    const modalTitle = document.getElementById("modalTitle");
    const modalDescription = document.getElementById("modalDescription");
    const commentsList = document.getElementById("commentsList");
    const newComment = document.getElementById("newComment");
    const addCommentBtn = document.getElementById("addComment");

    // Tymczasowe dane postów
    const posts = Array.from({ length: 30 }, (_, i) => ({
        title: `Post ${i + 1}`,
        description: `To jest opis posta ${i + 1}.`,
        image: `https://via.placeholder.com/300x200?text=Post+${i + 1}`,
        comments: [`Komentarz 1 do posta ${i + 1}`, `Komentarz 2 do posta ${i + 1}`]
    }));

    // Generowanie kafelków postów
    posts.forEach((post, index) => {
        const postTile = document.createElement("div");
        postTile.classList.add("post-tile");
        postTile.innerHTML = `
            <div class="photo-placeholder">
                <img src="${post.image}" alt="Zdjęcie posta ${index + 1}" style="width: 100%; border-radius: 5px;">
            </div>
            <h3>${post.title}</h3>
        `;
        postTile.addEventListener("click", () => openModal(post)); // Otwórz modal po kliknięciu
        forumContainer.appendChild(postTile);
    });

    // Funkcja otwierająca modala
    function openModal(post) {
        postModal.style.display = "flex";
        modalImage.src = post.image;
        modalTitle.textContent = post.title;
        modalDescription.textContent = post.description;

        // Wyczyść komentarze i wypełnij je na nowo
        commentsList.innerHTML = "";
        post.comments.forEach(comment => {
            const li = document.createElement("li");
            li.textContent = comment;
            commentsList.appendChild(li);
        });
    }

    // Zamknij modal
    closeModal.addEventListener("click", () => {
        postModal.style.display = "none";
    });

    // Dodaj nowy komentarz
    addCommentBtn.addEventListener("click", () => {
        const commentText = newComment.value.trim();
        if (commentText) {
            const li = document.createElement("li");
            li.textContent = commentText;
            commentsList.appendChild(li);
            newComment.value = ""; // Wyczyść pole tekstowe
        }
    });

    // Zamknięcie modala po kliknięciu poza jego obszarem
    window.addEventListener("click", (e) => {
        if (e.target === postModal) {
            postModal.style.display = "none";
        }
    });
});
