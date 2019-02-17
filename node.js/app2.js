function readFile(callback)
{
    callback();
}

var x = function()
{
    console.log("read file");
}

readFile(x);