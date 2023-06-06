// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//***********************************************//
//  Function used to open Web Page in new Tab    //
//***********************************************//
function newTab(tabURL) {
    let newWindowTab = window.open(tabURL);
};

//***********************************************//
//  Change background Color                      //
//***********************************************//
function changeBackgroundColor(newBackgroundcolor) {
    $('body').css('background-color', newBackgroundcolor);
}

//***********************************************//
//  Change background Image                      //
//***********************************************//
function changeBackgroundImage(newBackgroundImage) {
    $('body').css('background-image', newBackgroundImage);
}

//***********************************************//
//  Toggle Logo Language                         //
//***********************************************//
function eventToggleLogo() {

    // Update the first time.
    toggleLogo();

    // Set the countdown Interval.
    //setInterval(function () {
    //    toggleLogo();
    //}, 4500);
}

// Called by function eventToggleLogo
function toggleLogo() {    
  
    // English_Text - Show
    if (document.getElementById("Logo-Text-English").classList.contains('noshow')) {
        document.getElementById("Logo-Text-English").classList.replace('noshow', 'show');
        document.getElementById("Logo-Text-Spanish").classList.replace('show', 'noshow');
    } else {
        // Spanish_Text - Show
        if (document.getElementById("Logo-Text-Spanish").classList.contains('noshow')) {
            document.getElementById("Logo-Text-Spanish").classList.replace('noshow', 'show');
            document.getElementById("Logo-Text-English").classList.replace('show', 'noshow');
        }
    }
}

//***********************************************//
//   Toggle Seal Language                        //
//***********************************************//
function eventToggleSeal() {

    // Update the first time.
    toggleSealGold();

    // Set the countdown Interval.
    //setInterval(function () {
    //    toggleSealGold();
    //}, 4500);
}

// Called by function eventToggleSeal
function toggleSealGold() {

    // Seal_Gold - Show
    if (document.getElementById("Seal-Gold-Layer").classList.contains('noshow')) {
        document.getElementById("Seal-Gold-Layer").classList.replace('noshow', 'show');
    }

    // Seal_Gold_Body - Show
    if (document.getElementById("Seal-Gold-Body").classList.contains('noshow')) {
        document.getElementById("Seal-Gold-Body").classList.replace('noshow', 'show');
    }

    // Toggle...
    // Seal_Gold_English_Text - Show
    if (document.getElementById("Seal-Gold-English-Text").classList.contains('noshow')) {
        document.getElementById("Seal-Gold-English-Text").classList.replace('noshow', 'show');
        document.getElementById("Seal-Gold-Spanish-Text").classList.replace('show', 'noshow');
    } else {
        // Seal_Gold_Spanish_Text - Show
        if (document.getElementById("Seal-Gold-Spanish-Text").classList.contains('noshow')) {
            document.getElementById("Seal-Gold-Spanish-Text").classList.replace('noshow', 'show');
            document.getElementById("Seal-Gold-English-Text").classList.replace('show', 'noshow');
        }
    }
}

// Substitute this one for Black Seal
function toggleSealBlack() {

    // Seal_Black - Show
    if (document.getElementById("Seal-Black-Layer").classList.contains('noshow')) {
        document.getElementById("Seal-Black-Layer").classList.replace('noshow', 'show');
    }

    // Seal_Black_Body - Show
    if (document.getElementById("Seal-Black-Body").classList.contains('noshow')) {
        document.getElementById("Seal-Black-Body").classList.replace('noshow', 'show');
    }

    // Toggle...
    // Seal_Black_English_Text - Show
    if (document.getElementById("Seal-Black-English-Text").classList.contains('noshow')) {
        document.getElementById("Seal-Black-English-Text").classList.replace('noshow', 'show');
        document.getElementById("Seal-Black-Spanish-Text").classList.replace('show', 'noshow');
    //} else {
    //    // Seal_Black_Spanish_Text - Show
    //    if (document.getElementById("Seal-Black-Spanish-Text").classList.contains('noshow')) {
    //        document.getElementById("Seal-Black-Spanish-Text").classList.replace('noshow', 'show');
    //        document.getElementById("Seal-Black-English-Text").classList.replace('show', 'noshow');
    //    }
    }

    //***********************************************//
    //  Create Folder List of File Items  (Obsolete) //
    //***********************************************//
    function createFolderList(folderURL, filecount, extension, imageWidth, imageHeight) {

        extension = extension.toLowerCase();

        if (filecount > 0) {

            let fullFileName = "";
            let htmlString = "";
            let altText = "";

            let i = 1;
            while (i <= filecount) {
                altText = "";
                altText = altText.concat("00".concat(i).slice(-3)) + extension;
                fullFileName = folderURL + altText;

                if (extension == ".mp4") {

                    // Display Video (.mp4)
                    htmlString += "<div class='col-12 col-lg-4 text-center px-1 py-2'>" +
                        "<a href='" + fullFileName + "' target='_blank'>" +
                        "<video width=" + imageWidth +
                        " height=" + imageHeight +
                        " class='img-fluid bg-white border border-black h-100 p-2'" +
                        " controls preload='metadata'>" +
                        "<source src='" + fullFileName + "#t=2.5' type='video/mp4'>" +
                        "</video>" +
                        "</div>";

                } else {

                    // Display Picture (.jpg or svg)
                    htmlString += "<div class='col-12 col-lg-3 text-center py-2'>" +
                        "<a href='" + fullFileName + "' target='_blank'>" +
                        "<img width=" + imageWidth +
                        " height=" + imageHeight +
                        " class='img-fluid bg-white border border-black h-100 p-2'" +
                        " src='" + fullFileName + "'" +
                        " alt='" + altText + "'/> " +
                        "</a>" +
                        "</div>";

                }

                i++;

            };

            document.getElementById("imagelist").innerHTML = htmlString;

        };

    }

    //***********************************************//
    //  Create Image List of Carousel Items          //
    //                                               //
    //***********************************************//
    function createCarouselList(imageLocation, imageCount) {

        var text = "";
        var altText = ""
        var i = imageCount;

        // Create the needed "active" element
        text = "<div class='carousel-item active'><img class='d-block w-100' src='" + imageLocation.concat("000".concat(i).slice(-3)) + ".jpg' alt='" + altText.concat("000".concat(i).slice(-3)) + "' /></div>";
        i--;

        // Add the rest of the elements
        while (i > 0) {
            text += "<div class='carousel-item'><img class='d-block w-100' src='" + imageLocation.concat("000".concat(i).slice(-3)) + ".jpg' alt='" + altText.concat("000".concat(i).slice(-3)) + "' /></div>";
            i--;
        }

        document.getElementById("CarouselItems").innerHTML = text;

    }

}

