using System;
using CommandAPI.Models;
using Xunit;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command commandTest = new Command();

        public CommandTests()
        {
            commandTest = new Command()
            {   
                HowTo = "Do Something",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange

            //Act
            commandTest.HowTo = "Execute unit test";

            //Assert
            Assert.Equal("Execute unit test", commandTest.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange

            //Act
            commandTest.Platform = "Execute unit test";

            //Assert
            Assert.Equal("Execute unit test", commandTest.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange

            //Act
            commandTest.CommandLine = "Execute unit test";

            //Assert
            Assert.Equal("Execute unit test", commandTest.CommandLine);
        }

        public void Dispose()
        {
            commandTest = null;
        }
    }
}