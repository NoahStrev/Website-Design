async function getSweets() {   
    whaturl = "api/CandyInfo/sweets";
    console.log(whaturl);
    reponse = await fetch(whaturl);
    console.log(reponse);
    data = await reponse.json();
    console.log(data);
    console.log(data.length);
    console.log(data[0].productNum);
    msg = "";
    for (i = 0; i < data.length; i++) {
        msg += "Product Number " + data[i].productNum + " is described as a " + data[i].description + " with a Price Per Pound of " + data[i].pricePerPound + ".<br/><br/>"
        console.log(i)
    }

    document.getElementById('displaychoice').innerHTML = msg;
}

async function getaverageprice() {
    whaturl = "api/CandyInfo/averageprice";
    console.log(whaturl);
    reponse = await fetch(whaturl);
    console.log(reponse);
    data = await reponse.json();
    console.log(data);

    pounds = document.getElementById("lbs").value;
    console.log(pounds);

    final = data * pounds;
    final = final.toFixed(2)

    document.getElementById('mysteryestimate').innerHTML = final;
}