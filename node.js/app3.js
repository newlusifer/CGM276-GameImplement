var callback = function(para)
{
    console.log("Do somthing",para);
}

function myFunction(param,func)
{
    func(param);
}

myFunction("say",callback);