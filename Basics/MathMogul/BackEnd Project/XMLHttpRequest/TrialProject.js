
let xmlRequest =  new XMLHttpRequest();
let page =  document.getElementById('page');
let ol = document.createElement('ol');
page.appendChild(ol);
var  docLi= document.createElement('li');
          ol.appendChild(docLi);
        docLi.id="list";
// xmlRequest.onreadystatechange = function()
// {
//     if(xmlRequest.readyState== 4 && xmlRequest.status==200) 
//     {
//        const responsesConverted= JSON.parse(xmlRequest.response);
//        for(let  response of responsesConverted)
//        {
//           var  docLi= document.createElement('li');
//           ol.appendChild(docLi);
//           docLi.id="list";
//          docLi.innerText = `${response.theWord} :  ${response.definition}`;
//          console.table(docLi);
//        }
//        console.log(responsesConverted);
//     }
// }
// var clickbutton =  document.getElementById('button');
// clickbutton.addEventListener('click', function () {
//     xmlRequest.open("Get", "https://localhost:5001/GetAll");
//     xmlRequest.send();
// });
function CreateContext(url, lang) 
{
    let xHRequest = new XMLHttpRequest();
    xHRequest.open('Get',url);
    xHRequest.send();
    xHRequest.onload = () =>
    {
        lang(JSON.parse(xHRequest.response));
    }
}
function AddTags(response)
{
    let img = document.createElement('img');
    img.style.maxHeight="100px";
    img.style.accentColor="brown";
    img.style.maxWidth = "500px";
    let list = document.getElementById('list');
    img.src = response.message;
    list.appendChild(img);
}
dogbtn =  document.getElementById('dogbtn');
 dogbtn.addEventListener('click' , function () {
    CreateContext('https://dog.ceo/api/breeds/image/random',AddTags)
});

// function PrintIfEvenNumber(number)
// {
//     return new Promise(function(resolve,reject)
 //     {
//            setTimeout(function()
//            {
//                if (number%2==0) 
//                {
//                    resolve(number);
//                }
//                else{
//                    reject(console.error("Not An Even number"));
//                }
//            },3000)
//     })

// }
// function PrintDoubleNumber(num)
// {
//     return new Promise(function(resolve, reject) 
//     {
//         setTimeout(function ()
//         {
//             resolve(num*2);
//         },3000)
//     })
// } 
//  function PrintFailure()
// {
//     console.error('It Failed');
// }
// PrintIfEvenNumber(19)
// .then(function(value)
// {
//   console.log('It is an even number');
//   return PrintDoubleNumber(value);
// })
// .then(function(double)
// {
//   console.log(double);
// }).catch(PrintFailure);
