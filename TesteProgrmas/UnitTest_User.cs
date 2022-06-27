using _05_WebAPP.MVC.Models;
using _05_WebAPP.MVC.Interfaces;
using Moq;

namespace TesteProgrmas;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_UserADD()
    {
        var _us = new Mock<IUserService>();
        var _userMoke = new Mock<User>();
        var u = new User()
        {
            nome = "Carlos",
            nick = "CC",
            email = "Carlos@email.com",
            pass = "123",
            ativo = true
        };

        _us.Setup(x => x.AddAsync(u));

        Assert.Pass();
    }
}