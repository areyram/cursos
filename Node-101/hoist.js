function isTruthy(value) {
    var x = 321;
    if (value) {
        console.log(x);
        let x = 123;    // vs var
        console.log(x);
        return true;
    }
    return false;
}
isTruthy(1);