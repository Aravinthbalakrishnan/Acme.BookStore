using Acme.BookStore.Books;
using Acme.BookStore.Parties;
using Acme.BookStore.UserTypes;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


        CreateMap<Book, BookDto>().ReverseMap();    
       
        CreateMap<CreateUpdateBookDto, Book>();

        CreateMap<UserType, UserTypeDto>().ReverseMap();
        CreateMap<CreateUpdateUserTypeDto, UserType>();


        CreateMap<Partie, PartieDto>().ReverseMap();
        CreateMap<CreateUpdatePartieDto, Partie>();

    }


    }

