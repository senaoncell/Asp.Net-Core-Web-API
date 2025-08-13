using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { BookId = 1, CategoryId = 1, BookTitle = "Bilgisayar Bilimine Giriş", BookPrice = 75 },
                new Book { BookId = 2, CategoryId = 2, BookTitle = "Bilgisayar Ağları", BookPrice = 175 },
                new Book { BookId = 3, CategoryId = 1, BookTitle = "Derin Öğrenme", BookPrice = 375 }
           );
        }
    }
}
