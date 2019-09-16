// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
//利用JavaScript计算出：[(23+7)x12-8]÷6的值
var i = 0;
i = [(23 + 7) * 12 - 8] / 6
console.log(i);



//利用循环，计算出2 + 4 + 6 + 8 +...+100=?
var sum = 0;
for (var i = 0; i = i + 2; i <= 100) {
    sum += i
}
console.log(sum);


//将源栈同学姓名/昵称装入数组，再根据该数组输出所有同学，以及共有多少位同学


var students = ['A', 'B', 'C', 'D',];
arr = students
console.log(arr, length);



//如果一个数只能被1和它自己整除，这个数就被称之为“素数”。请找出100以内的所有素数。
var x = 7;
for (var i = 2; i++; i <= 100)
    if (x % i === 0) {
        console.log(x + '不是质数');
        break;
    } else {
        if (i === x - 1) {
            console.log(x + '不是质数');
        }
    }


//将之前“找出素数”的代码封装成一个函数findPrime(max)，可以打印出max以内的所有素数。
function findPrime(max) {
    for (varx = 2; x < max; x++) {
        for (vari = 2; i < x; i++) {
            if (x % i === 0) {
                break;
            }
            elsa{
                if (i === x - 1) {
                    console.log(x + '是质数');
                }
            }
        }
    }
}


//自行设计参数，将之前“累加求和”的代码封装成一个函数Sum()，可以计算任意起始位置、任意步长（如：1,3,5……或者0,5,10,15……）的等差数列之和。

var sum = function (first, step, last) {
    //设置首项，公差，末项
    var j = 0, i = 0;
    while (j < x) {
        j = j + 'step';
        i = i + j;
    }
    return i;
}




//封装一个函数Swap(arr, i, j)，可以交换数组arr里下标 i 和 j 的值
var arr[i, j];
function Swap(arr, i, j) {
    var temp = [i, j];
    arr[i] = arr[j];
    arr[b] = temp
}
swap(arr, 0, 1);
console.log('arr[i]=' + arr[i]);
console.log('arr[j]=' + arr[j]);


//删除一个数组里面重复的元素

var arr[];
for (var i = 0; i < this.length; i++) {
    if (arr1.indexOf(this[i]) == -1) {
        arr.push(this[i]);
    }
    return console.log(arr);
}


//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：“飞哥”改成“大神”，“线下”改成“线上”。
var string = "'源站':飞哥小班教学,线下免费收看";
newString = string.replace("飞哥", "大神");
newString = newString.replace("线下", "线上");



//将数组['why','gIT','vs2019','community','VERSION']规范化，所有字符串：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'
function standard(str) {
    var arr = [];
    for (var i = 0; i < str.length; i++) {
        arr[i] = str[i].toLowerCase().slice(0, 6);
        arr[i] = arr[i][0].toUpperCase() + arr[i].substring(1, 6);
    }
    return arr;
}
var str = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
var result = standard(str);

//不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
function order(call) {
    var callde = "";
    for (vari = call.length - 1; i >= 0; i--) {
        called += call[i];
    }
    return called;
}
console.log(order("hello,yuanzhan"));

/*封装一个函数，建立一个函数getMaxNumber()，可以接受任意多各种类型（整数、小数、正数、负数、字符串、布尔值等）的参数，
  并找出里面最大的数（忽略其他类型）*/
function getMaxNumber() {
    var result = -Infinity;
    for (var i = 0; i < arguments.length; i++) {
        if (typeof arguments[i] === typeof 0) {
            if (arguments[i] > result) {
                result = arguments[i];
                else {

                }
            } else
        }
    }
    return result;

}

//构建一个函数has9(number) ，可以判断number中是否带有数字9；
//构建一个函数has6(number) ，可以判断number中是否带有数字6；
//构建一个函数has8(number) ，可以判断number中是否带有数字8；
function has9(number) {
    return hasX(number, 9);
}
function has8(number) {
    return hasX(number, 8);
}
function has6(number) {
    return hasX(number, 6);
}
function hasX(number, X) {
        return String(number).indexOf(X) >= 0;
}
//使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
var get986 = function (number) {
    var result = 0;
    for (var i = 0; i < number + 1; i++) {
        if (has9(i) || has8(i) || has6(i)) {
            result++;
        }
        else {

        }
    }
    console.log(result);
}

/*完成猜数字的游戏：
 *弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
 *浏览器生成一个不大于1000的随机正整数；
 *用户输入猜测；
 *只用了不到6次就猜到，弹出：碉堡了！
 *只用了不到8次就猜到，弹出：666！
 *用了8-10次猜到，弹出：猜到了。
 *用了10次都还没猜对，弹出：^(*￣(oo)￣)^  */
var bingo = 876;
if (confirm(`弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
浏览器生成一个不大于1000的随机正整数；
用户输入猜测；
如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
只用了不到6次就猜到，弹出：碉堡了！
只用了不到8次就猜到，弹出：666！
用了8-10次猜到，弹出：猜到了。
用了10次都还没猜对，弹出：^(*￣(oo)￣)^`)) {
    bingoGame()
} else {
}
function bingoGame() {
    for (var i = 0; i < 10; i++) {

        var word = prompt("请输入你猜测的数字:' '");
        if (!word) {
            break;
        }
        if (!isNaN(word) && word > 0 && word.indexOf(".") === -1) {
            if (+word < bingo) {
                alert("小了");
            } else if (+word > bingo) {
                alert("大了");
            }
            if (+word === bingo) {
                if (i < 6) {
                    alert("碉堡了！");

                } else if (i < 8) {
                    alert("666!");


                } else if (i < 9) {
                    alert("猜到了！");
                } else if (i = 9) {
                    alert("^(*￣(oo)￣)^");
                } break;

                if (+word > bingo) {
                    alert("小了");
                } else {
                    alert("大了");
                }
 
            }
        }

        else {
            alert("请输入正整数！");

        }

    } return false;

} 


//使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：
//第n周，源栈同学random人。（n逐次递增，random随机）
var n = 1;
function greet() {
    if (n < 30) {
        setTimeout(function (){
            console.log("第" + n + "周，源栈同学" +
                Math.floor(Math.random() * 100) + "人");
            n++;
            greet();
        }, 1000);
    } else { }
} greet();















