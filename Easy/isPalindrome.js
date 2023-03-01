/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    let integerToString = String(x);
    let comparison = String(x);
    
    if (integerToString.split('').reverse().join('') == comparison){
        return true;
    }
    else{
        return false;
    }
};