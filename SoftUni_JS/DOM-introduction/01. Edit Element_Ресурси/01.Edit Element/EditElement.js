function editElement(reference,match,replacer) {
    const contest=reference.textContent;
    const matcher= new RegExp(match,'g');
    let result=contest.replace(matcher,replacer);
    reference.textContent=result;
    // TODO
}