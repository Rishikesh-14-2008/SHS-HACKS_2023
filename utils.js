function makeElement(type = "div", newClass, inner = ""){
    let newEl=document.createElement(type);
    if(newClass) newEl.classList.add(newClass);
    newEl.innerHTML=inner;
    return newEl;
}
export { makeElement };