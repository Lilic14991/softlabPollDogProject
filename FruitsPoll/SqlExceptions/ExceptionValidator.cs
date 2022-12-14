namespace PollDog.API.SqlExceptions
{
    public static class ExceptionValidator
    {
        /// <summary>Validators the specified brand.</summary>
        /// <param name="brand">The brand.</param>
        public static void Validator(DTO.BrandCreate brand)
        {
            if (brand == null)
            {
                throw new SqlExceptionHelper($"{nameof(brand)} is null.");
            }
            else if (string.IsNullOrEmpty(brand.Name))
            {
                throw new SqlExceptionHelper($"{nameof(brand.Name)} is Null/Empty/Whitespace");
            }
        }
    }
}
