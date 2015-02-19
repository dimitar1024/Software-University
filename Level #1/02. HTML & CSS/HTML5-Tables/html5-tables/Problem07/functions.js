
// DECLARE AND INITIALIZE VARIABLES

var zero = '0';
var one = '1';
var two = '2';
var three = '3';
var four = '4';
var five = '5';
var six = '6';
var seven = '7';
var eight = '8';
var nine = '9';
var add = '+';
var subtract = '-';
var multiply = '*';
var divide = '/';


// FUNCTIONS 

function compute(f)
{
    f.view.value = eval(f.view.value);
}

function getNum(f,val)
{
    f.view.value += val;
}