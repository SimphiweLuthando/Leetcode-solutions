/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function(s) {
    //     const romanToIntMap = {
    //     'I': 1,
    //     'V': 5,
    //     'X': 10,
    //     'L': 50,
    //     'C': 100,
    //     'D': 500,
    //     'M': 1000
    //   };
    
    //   let result = 0;
    //   let prevValue = 0;
    
    //   for (let i = s.length - 1; i >= 0; i--) {
    //     const currentValue = romanToIntMap[s[i]];
    //     if (currentValue >= prevValue) {
    //       result += currentValue;
    //     } else {
    //       result -= currentValue;
    //     }
    //     prevValue = currentValue;
    //   }
    
    //   return result;
    
     let result = 0;
      let prevValue = 0;
    
      for (let i = s.length - 1; i >= 0; i--) {
        const currentChar = s[i];
        let currentValue;
    
        switch (currentChar) {
          case 'I':
            currentValue = 1;
            break;
          case 'V':
            currentValue = 5;
            break;
          case 'X':
            currentValue = 10;
            break;
          case 'L':
            currentValue = 50;
            break;
          case 'C':
            currentValue = 100;
            break;
          case 'D':
            currentValue = 500;
            break;
          case 'M':
            currentValue = 1000;
            break;
        }
    
        if (currentValue >= prevValue) {
          result += currentValue;
        } else {
          result -= currentValue;
        }
        prevValue = currentValue;
      }
    
      return result;
    
    };