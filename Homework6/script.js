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

quotenum = 1;
async function getquote(){   
    let whatUrl = "dummyjson.com/quotes/1";
    response = await fetch("https://dummyjson.com/quotes/" + quotenum);
    quotenum++;

    data = await response.json();
    console.log(data);
    console.log("quote+ " + data.quote);
    console.log("author+ " + data.author);

    msg =  data.quote +"<br> -" + data.author;
    document.getElementById('quotesection').innerHTML = msg;
}