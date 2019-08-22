namespace MISA.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MISA.Entities.MISAWDT02NTHTrangContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MISA.Entities.MISAWDT02NTHTrangContext context)
        {
            context.Refs.AddOrUpdate(p => p.RefID,
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2019, 11, 06),
                    RefNo = "PT0001",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "1",
                    RefPhone ="123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2019, 12, 06),
                    RefNo = "PT0002",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "1",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2018, 05, 06),
                    RefNo = "PT0003",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "1",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2019, 05, 09),
                    RefNo = "PT0004",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "1",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2019, 01, 06),
                    RefNo = "PT0005",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "1",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2019, 07, 06),
                    RefNo = "PT0006",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "1",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2019, 06, 06),
                    RefNo = "PT0007",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "3",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2010, 05, 07),
                    RefNo = "PT0008",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "2",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2014, 12, 06),
                    RefNo = "KH0002",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "1",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2013, 12, 06),
                    RefNo = "PT0003",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "12",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2015, 12, 06),
                    RefNo = "PT0004",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "13",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2012, 12, 06),
                    RefNo = "PT0005",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "11",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2016, 12, 06),
                    RefNo = "PT0006",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "10",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2018, 12, 06),
                    RefNo = "PT0007",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "2",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2017, 12, 06),
                    RefNo = "PT0008",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "3",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2018, 12, 06),
                    RefNo = "PT0009",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "13",
                    RefPhone = "123",
                },
                new Ref()
                {
                    RefID = Guid.NewGuid(),
                    RefBirth = new DateTime(2019, 12, 06),
                    RefNo = "PT0022",
                    ContactName = "Trang",
                    Note = "Thu nợ",
                    Status = "no",
                    Group = "4",
                    RefPhone = "123",
                }

                );
        }
    }
}
