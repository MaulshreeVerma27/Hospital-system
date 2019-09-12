
function validation() {
    
    var name = document.getElementById("username").value;
    var email = document.getElementById("id").value;

    alert(name);
    var emailReg = /^([w-.]+@([w-]+.)+[w-]{2,4})?$/;

    document.write(name);
  
}