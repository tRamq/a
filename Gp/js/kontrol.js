function UyeOlKontrol(frm)
{
	var adi=frm.adi.value;
	var soyadi=frm.soyadi.value;
	var kadi=frm.kadi.value;
	var sifre=frm.sifre.value;
	var sifretekrar=frm.sifretekrar.value;
	var email=frm.email.value;
	var atpos=email.indexOf("@");
    var dotpos=email.lastIndexOf(".");
	

	if(adi.length<4)
	{
		document.getElementById("adikontrol").innerHTML=" 4 karakterden kısa isim olamaz";
		document.getElementById("adikontrol").style.color="red";
	return false;
	}
	
    if(soyadi.length<4)
    {
	    document.getElementById("soyadikontrol").innerHTML="4 karakterden kısa soyad olamaz";
	    document.getElementById("soyadikontrol").style.color="red";
	return false;
	}
	if(kadi.length<5)
    {
	    document.getElementById("kadikontrol").innerHTML="5 karakterden kısa Kullanıcı adı olamaz";
	    document.getElementById("kadikontrol").style.color="red";
	return false;
	}
	if(sifre.length<1)
    {
	    document.getElementById("sifrekontrol").innerHTML="Şifre boş olamaz";
	    document.getElementById("sifrekontrol").style.color="red";
	return false;
	}
	if(  !(sifre == sifretekrar)  )
    {
	    document.getElementById("sifretekrarkontrol").innerHTML="Şifreler aynı değil";
	    document.getElementById("sifretekrarkontrol").style.color="red";
	return false;
	}
	if ( atpos<1 || dotpos<atpos+2 || dotpos+2>=email.length )
    {
        document.getElementById("emailkontrol").innerHTML="Geçerli email adresi giriniz";
	    document.getElementById("emailkontrol").style.color="red";
        return false;
	}
	alert("Başarıyla kayıt yaptınız..."); 
	return true;
    
}
function KisiSil(frm)
{
	var kadi=frm.kadi.value;
	var email=frm.email.value;
	var atpos=email.indexOf("@");
	var dotpos=email.lastIndexOf(".");
	if(kadi.length<4)
    {
	    document.getElementById("kadikontrol").innerHTML="4 karakterden kısa Kullanıcı adı olamaz";
	    document.getElementById("kadikontrol").style.color="red";
	return false;
	}
	if ( atpos<1 || dotpos<atpos+2 || dotpos+2>=email.length )
    {
        document.getElementById("emailkontrol").innerHTML="Geçerli email adresi giriniz";
	    document.getElementById("emailkontrol").style.color="red";
        return false;
	}
	alert("Başarıyla kişiyi sildiniz yaptınız..."); 
	return true;
	
}
