namespace UserCases
{
    public interface IRecordTransactionUseCase
    {
        void Execute(string casherName, int productId, int qty);
    }
}