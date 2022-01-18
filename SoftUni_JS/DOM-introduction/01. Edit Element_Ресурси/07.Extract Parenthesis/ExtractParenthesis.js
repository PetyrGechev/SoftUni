function extract(content) {
let text=document.getElementById('content').textContent;
let result='';
let pattent=/\((.*?)\)/g;
let match=pattent.exec(text);
while(match!=null){
    result+=match[1];
    result+='; ';
    match=pattent.exec(text);
}
return result;
}