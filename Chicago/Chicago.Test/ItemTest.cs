using Chicago.Bll;
using Chicago.Dal.Models;
using Daytona;
using Microsoft.EntityFrameworkCore.Query;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Chicago.Test
{
    public class ItemTest
    {
        readonly IChicagoManager<Bll.Dto.Item> Manager;
        readonly List<Item> Items;

        public ItemTest()
        {
            Items = new List<Item>
            {
                new Item
                {
                    Id = 1,
                    Name = "House",
                    Type = Dal.Enums.WorthType.Asset,
                    Balance = 200f
                }
            };

            var repository = new Mock<IRepository<Item>>();
            repository.Setup(r => r.GetById(It.IsAny<int>(),
                    It.IsAny<Func<IQueryable<Item>, IIncludableQueryable<Item, object>>>()))
                .ReturnsAsync((int i, string[] x) => Items.SingleOrDefault(f => f.Id == i));
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
