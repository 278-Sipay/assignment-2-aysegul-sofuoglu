using AutoMapper;
using SipayApi.DataAccess.Domain;


namespace SipayApi.Schema;

    public class MapperConfig:Profile
    {
    public MapperConfig()
    {

        CreateMap<TransactionRequest, Transaction>();
        CreateMap<Transaction, TransactionResponse>();
    }
}
