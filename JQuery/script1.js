
$(document).ready(function(){
   
    $('#btn1').click(()=>{
     var name = $('#txt1').val();
     if(name == ""){
         $('#spn1').html("Name cannot be empty");
         $('#spn1').css("color", "red");
         return;
     }
     $('#spn1').html("Hello " + name);
     $('#spn1').css("color", "green");
    });
    $('#btn2').click(()=>{
        fetch('https://jsonplaceholder.typicode.com/posts')
        .then(response => response.json())
        .then(data => {
            var str = $("#div1").html();
            str += "<table id='tbl1'><tr><th>Id</th><th>Title</th></tr>";
            data.forEach(element => {
                str += "<tr><td>" + element.id + "</td><td>" + element.title + "</td></tr>";
            });
            str += "</table>";
            $('#div1').html(str);
        })  
   })
   $('#btn3').click(()=>{
    var data = $('#btn3').html();
    if(data == "Show Less"){
        $("#tbl1").slideUp(1000);
        $('#btn3').html("Show More");
    }
    else{
        $("#tbl1").slideDown(1000);
        $('#btn3').html("Show Less");
    }
    //$("#div4").slideUp(1000);
   });
    $('#btn4').click(()=>{
     $("#div4").slideDown(1000);
    });
 });