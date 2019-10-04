// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
//利用JavaScript计算出：[(23+7)x12-8]÷6的值
//var i = 0;
//i = [(23 + 7) * 12 - 8] / 6
//console.log(i);



//利用循环，计算出2 + 4 + 6 + 8 +...+100=?
//var sum = 0;
//for (var i = 0; i = i + 2; i <= 100) {
//    sum += i
//}
//console.log(sum);


//将源栈同学姓名/昵称装入数组，再根据该数组输出所有同学，以及共有多少位同学


//var students = ['A', 'B', 'C', 'D',];
//arr = students
//console.log(arr, length);



//如果一个数只能被1和它自己整除，这个数就被称之为“素数”。请找出100以内的所有素数。
//var x = 7;
//for (var i = 2; i++; i <= 100)
//    if (x % i === 0) {
//        console.log(x + '不是质数');
//        break;
//    } else {
//        if (i === x - 1) {
//            console.log(x + '不是质数');
//        }
//    }


//将之前“找出素数”的代码封装成一个函数findPrime(max)，可以打印出max以内的所有素数。
//function findPrime(max) {
//    for (varx = 2; x < max; x++) {
//        for (vari = 2; i < x; i++) {
//            if (x % i === 0) {
//                break;
//            }
//            elsa{
//                if (i === x - 1) {
//                    console.log(x + '是质数');
//                }
//            }
//        }
//    }
//}


//自行设计参数，将之前“累加求和”的代码封装成一个函数Sum()，可以计算任意起始位置、任意步长（如：1,3,5……或者0,5,10,15……）的等差数列之和。

//var sum = function (first, step, last) {
//    //设置首项，公差，末项
//    var j = 0, i = 0;
//    while (j < x) {
//        j = j + 'step';
//        i = i + j;
//    }
//    return i;
//}




//封装一个函数Swap(arr, i, j)，可以交换数组arr里下标 i 和 j 的值
//var arr[i, j];
//function Swap(arr, i, j) {
//    var temp = [i, j];
//    arr[i] = arr[j];
//    arr[b] = temp
//}
//swap(arr, 0, 1);
//console.log('arr[i]=' + arr[i]);
//console.log('arr[j]=' + arr[j]);


//删除一个数组里面重复的元素

//var arr[];
//for (var i = 0; i < this.length; i++) {
//    if (arr1.indexOf(this[i]) == -1) {
//        arr.push(this[i]);
//    }
//    return console.log(arr);
//}


//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：“飞哥”改成“大神”，“线下”改成“线上”。
//var string = "'源站':飞哥小班教学,线下免费收看";
//newString = string.replace("飞哥", "大神");
//newString = newString.replace("线下", "线上");



//将数组['why','gIT','vs2019','community','VERSION']规范化，所有字符串：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'
//function standard(str) {
//    var arr = [];
//    for (var i = 0; i < str.length; i++) {
//        arr[i] = str[i].toLowerCase().slice(0, 6);
//        arr[i] = arr[i][0].toUpperCase() + arr[i].substring(1, 6);
//    }
//    return arr;
//}
//var str = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
//var result = standard(str);

//不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
//function order(call) {
//    var callde = "";
//    for (vari = call.length - 1; i >= 0; i--) {
//        called += call[i];
//    }
//    return called;
//}
//console.log(order("hello,yuanzhan"));

/*封装一个函数，建立一个函数getMaxNumber()，可以接受任意多各种类型（整数、小数、正数、负数、字符串、布尔值等）的参数，
  并找出里面最大的数（忽略其他类型）*/
//function getMaxNumber() {
//    var result = -Infinity;
//    for (var i = 0; i < arguments.length; i++) {
//        if (typeof arguments[i] === typeof 0) {
//            if (arguments[i] > result) {
//                result = arguments[i];
//                else {

//                }
//            } else
//        }
//    }
//    return result;

//}

//构建一个函数has9(number) ，可以判断number中是否带有数字9；
//构建一个函数has6(number) ，可以判断number中是否带有数字6；
//构建一个函数has8(number) ，可以判断number中是否带有数字8；
//function has9(number) {
//    return hasX(number, 9);
//}
//function has8(number) {
//    return hasX(number, 8);
//}
//function has6(number) {
//    return hasX(number, 6);
//}
//function hasX(number, X) {
//        return String(number).indexOf(X) >= 0;
//}

//使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
//var get986 = function (number) {
//    var result = 0;
//    for (var i = 0; i < number + 1; i++) {
//        if (has9(i) || has8(i) || has6(i)) {
//            result++;
//        }
//        else {

//        }
//    }
//    console.log(result);
//}

/*完成猜数字的游戏：
 *弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
 *浏览器生成一个不大于1000的随机正整数；
 *用户输入猜测；
 *只用了不到6次就猜到，弹出：碉堡了！
 *只用了不到8次就猜到，弹出：666！
 *用了8-10次猜到，弹出：猜到了。
 *用了10次都还没猜对，弹出：^(*￣(oo)￣)^  */
//var bingo = 876;
//if (confirm(`弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8-10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^(*￣(oo)￣)^`)) {
//    bingoGame()
//} else {
//}
//function bingoGame() {
//    for (var i = 0; i < 10; i++) {

//        var word = prompt("请输入你猜测的数字:' '");
//        if (!word) {
//            break;
//        }
//        if (!isNaN(word) && word > 0 && word.indexOf(".") === -1) {
//            if (+word < bingo) {
//                alert("小了");
//            } else if (+word > bingo) {
//                alert("大了");
//            }
//            if (+word === bingo) {
//                if (i < 6) {
//                    alert("碉堡了！");

//                } else if (i < 8) {
//                    alert("666!");


//                } else if (i < 9) {
//                    alert("猜到了！");
//                } else if (i = 9) {
//                    alert("^(*￣(oo)￣)^");
//                } break;

//                if (+word > bingo) {
//                    alert("小了");
//                } else {
//                    alert("大了");
//                }

//            }
//        }

//        else {
//            alert("请输入正整数！");

//        }

//    } return false;

//} 


//使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：
//第n周，源栈同学random人。（n逐次递增，random随机）
//var n = 1;
//function greet() {
//    if (n < 30) {
//        setTimeout(function (){
//            console.log("第" + n + "周，源栈同学" +
//                Math.floor(Math.random() * 100) + "人");
//            n++;
//            greet();
//        }, 1000);
//    } else { }
//} greet();

//在函数student()中声明了函数域变量name、age和female，
//使用闭包机制，将其暴露到函数外部
//function student() {
//    var name = '曾俊清', age = 22;
//    var obj = { name, age }
//    return function () {
//        return obj;
//    }
//}

//参考用户注册页面，创建一下函数：
//显示密码的长度
//如果密码和确认密码不一致，弹出提示
//var str = document.getElemenstByClass("word");
////var str = 0123456;
//alert(str.length);
////var sstr = 0123456;
//var sstr = document.getElemenstByClass("sword");
//if (str === sstr) {
//    alert("密码输入正确");
//} else {
//    alert("密码输入错误");
//}



//参考一起帮首页，实现右侧漂浮并底对齐左侧文本框的效果

//参考求助首页侧边栏“免费广告发布”弹出Modal，实现（不需要弹出Modal）：
//根据下拉列表选中项，填充“文字内容”和“链接”文本框
//勾选修改的checkbox，实现“文字内容”和“链接”文本框的禁用和启用

//var selectobj = document.getElementsByClassName("selectContent");
//selectobj[0].addEventListener('click', assign);
//function assign() {
//    var sIndex = selectobj[0].selectedIndex;
//    var assignContent = selectobj[0].children[sIndex].innerHTML;
//    document.getElementsByClassName("textContentDiv")[0].value = assignContent;
//    var obj = document.getElementsByClassName("modifier")[0];
//    obj.addEventListener('click', noModifier);
//}

//function noModifier() {
//    if (obj.checked) {
//        selectobj[0].removeEventListener('click', assign);
//        for (var i = 0; i < 2; i++) {
//            document.getElementsByClassName("textContentDiv")[i].value = "";
//            document.getElementsByClassName("textContentDiv")[i].setAttribute('readonly', 'readonly');

//        }
//    }
//    else {
//        selectobj[0].addEventListener('click', assign);
//        for (vari = 0; i < 2; i++) {
//            document.getElementsByClassName("textContentDiv")[i].removeAttribute('readonly');
//        }
//    }
//}



    //参考注册页面：
    //提交时，如果用户名重复（已有用户名用数组保存），阻止form提交，提示“用户名重复”。
    //重新输入用户名，一旦输入用户名部分没有重复，“用户名重复”的提示消失
    //当用户名或密码等有值时，关闭页面前弹出确认框

    //var user = ['A', 'B', 'C', 'D'];
    //a = 0;
    //document.getElementsByTagName('button')[0].addEventListener('click', validation);
    //function validation(event) {
    //    var username = document.getElementsByTagName('input')[0].value;
    //    for (var i = 0; i < user.length; i++) {
    //        if (user[i] === username) {
    //            document.querySelector('p'.setAttribute)('style', 'color: #ff0000; display: inline; fort - size: 15px;');
    //            a = 1;
    //            if (a === 1) {
    //                document.getElementsByTagName('input')[0].addEventListener('keyup', caneHint);

    //            }
    //            else { }
    //        }
    //    }
    //}
    //function caneHint() {
    //    var username = document.getElementsByTagName('input')[0].value;
    //    if (user.indexOf(username) === -1) {
    //        document.querySelector('p').removeAttribute('style');
    //        document.querySelector('p'.setAttribute)('style', 'color: #ff0000; display: inline; fort - size: 15px;');

    //    }
    //}


//参考发布求助，实现其关键字功能：
//没有选择一级关键字，不能选择二级关键字
//选择一级关键字后，二级关键字只能是一级关键字下的子集
//一级关键字和二级关键字被选中后，会显示在下拉列表上方
//自定义关键字输入完成后（按空格键），输入的关键字显示在下拉列表上方
//后输入的关键字显示在前面
//var firstLevel = ['编程语言', '工具软件', '操作系统'];
//var secondLevel = [
//    ['C#', 'HTML', 'SQL', 'CSS', 'JS'],
//    ['VS', 'IDEA', 'CAD', 'PS'],
//    ['Linux', 'Windows', 'Unix']
//];
//var contentKeyWord = document.getElementsByClassName('contentKeyWord')[0];
//var selectObj = document.getElementsByClassName('select')[0];

//function creatLabel(value) {
//    var label = document.createElement('label');
//    var labelText = document.createTextNode('value');
//    label.appendChild('labelText');
//    contentKeyWord.appendChild(label);

//}
//document.getElementsByClassName('starters')[0].onchange = function () {
//    var toSairIndex = selectObj.children[0].selectedIndex = -1;
//    //selectObj.children[1].innerHTML = ' <option value="" disabled selected hidden>第二级</option>';
//    for (var i = 0; i < toSair[toSairIndex].length; i++) {
//        var option = document.createElement('option');
//        var text = document.createTextNode(toSair[toSairIndex][i]);
//        option.appendChild[1].appendChild(option);
//    }
//    creatLabel(this.children[this.selectedIndex].innerText);
//}

//document.getElementsByClassName('secondLevel')[0].onchange = function (e) {
//    creatLabel(this.children[this.selectedIndex].innerText);
//}

//document.getElementsByClassName('cutonWord')[0].onkeypress = function (e) {
//    if (e.code === 'Space') {
//        creatLabel(this.value);
//        this.value = '';

//    }
//}


//JSON生成和解析：
//按自己的情况，生成一个JSON字符串，
//包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，
//上传到QQ群：一起帮·有意向（729600626）
//根据其他同学的JSON获得其个人资料，生成一个表格显示。
//    var zjq = {
//        name: '曾俊清',
//        age: 22,
//        isfemale: true,
//        hobby: ['basketball', 'sleep', 'eat'],
//        sourse: {
//            'C#': 88, 'js': 88, 'asp.net': 88
//        }
//    }
//console.log(JSON.stringify(zjq));



//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//<.+@.+\..+>

//是否是小数（正负小数都可以）
//<\d +\.\d | -\d\.\d >

//将所有以zyf - 开头的属性去掉zyf -
//（尽可能多的制造测试用例，比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）
//< (?<= zyf -).+>


//已有如下代码：
//请用不同的方式调用fn()函数，能分别打印出‘飞哥’和‘老程’
//不改变上述代码，分别使用call()和apply() ，打印出‘文轩’和‘两开花’
//将fn()永久拷贝到showName() ，始终打印‘源栈最棒！^ _ ^’

//var sname = "飞哥";
//var a = {
//    sname: '老程',
//    fn: function () {
//        console.log(this.sname);
//    }
//}
//a.fn();
//a.fn.call({ sname: '飞哥' });
//a.fn.call({ sname: '文轩' });
//a.fn.apply({ sname: '两开花' });
//let showName = a.fn.bind({ sname: '源栈最棒！^_^' });
//showName();
