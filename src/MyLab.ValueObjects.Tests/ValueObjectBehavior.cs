using System;
using CSharpFunctionalExtensions;
using Xunit;

namespace MyLab.ValueObjects.Tests
{
    public class ValueObjectBehavior
    {
        [Fact]
        public void ShouldCreateObjectWithPropertyInits()
        {
            //Arrange
            

            //Act


            //Assert

        }

        record TestValueObject : StrongValueObject<TestValueObject, (int Int,string String)>
        {
            public string String { init; get; }
            public int Int { init; get; }

            public TestValueObject((int Int, string String) p) : base(p)
            {
                
            }
            
            public override bool Validate()
            {
                throw new NotImplementedException();
            }
        }
    }
}
