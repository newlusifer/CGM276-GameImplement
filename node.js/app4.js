function myFunction(param,func)
{
    func(param);
}

myFunction("say",function(param)
{
    console.log("do somthing :",param);
});

