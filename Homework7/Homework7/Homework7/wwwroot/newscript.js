$(document).ready(function(){
    $("article.RomeoJuliet").hide();
    $("article.Hamlet").hide();
    $("article.MuchAdoNothing").hide();
    $("article.Tempest").hide();
    $("article.HenryOne").hide();
    $("article.HenryTwo").hide();

    $("p.RomeoJuliet").click(function(){
        $("article.RomeoJuliet").toggle();
    });
    $("p.Hamlet").click(function(){
        $("article.Hamlet").toggle();
    });
    $("p.MuchAdoNothing").click(function(){
        $("article.MuchAdoNothing").toggle();
    });
    $("p.Tempest").click(function(){
        $("article.Tempest").toggle();
    });
    $("p.HenryOne").click(function(){
        $("article.HenryOne").toggle();
    });
    $("p.HenryTwo").click(function(){
        $("article.HenryTwo").toggle();
    });
})

whichplay = 1;
async function getplay() {   
    whaturl = "api/Shakes/" + whichplay;
    console.log(+ whichplay);
    whichplay++;
    if (whichplay > 4) {
        whichplay = 1;
    }
    console.log(whaturl);
    reponse = await fetch(whaturl);
    console.log(reponse);
    data = await reponse.json();
    console.log(data);
    document.getElementById('quotesection').innerHTML = data.ptitle + " is a " + data.playtpe + " play with main characters " + data.mainchar1 + " and " + data.mainchar2 + ".<br/><br/>A breif description of this play is: " + data.briefdesc
}