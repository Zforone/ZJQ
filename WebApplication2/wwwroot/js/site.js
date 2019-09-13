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

//独立完成“冒泡排序”算法


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
    varj = 0, i = 0;
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


//统计出这段文字中有多少个单词：


//在上述数组头部加上小鱼老师，末尾加上大飞哥


//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：“飞哥”改成“大神”，“线下”改成“线上”。
var string = "'源站':飞哥小班教学,线下免费收看";
newString = string.replace("飞哥", "大神");
newString = newString.replace("线下", "线上");



//将数组['why','gIT','vs2019','community','VERSION']规范化，所有字符串：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'
var string =

//不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
function order(call) {
    var callde = "";
    for (vari = call.length - 1; i >= 0; i--) {
        called += call[i];
    }
    return called;
}
console.log(order("hello,yuanzhan"));

