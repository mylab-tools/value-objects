
using CSharpFunctionalExtensions;

namespace MyLab.ValueObjects
{
    public abstract partial record StrongValueObject<T, TParam>: StrongValueObject
        where T: StrongValueObject
    {
        protected StrongValueObject(TParam p) 
        {
        }
        
        public Result<T> Create()
        {

        }

        public static partial bool Validate(TParam p);
    }

    public abstract record StrongValueObject
    {
        
    }
}
