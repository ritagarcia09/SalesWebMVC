using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;
        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;  // DB has been seeded
            }

            Department d1 = new Department(1, "Infraestrutura");
            Department d2 = new Department(2, "Tecnologia da Informação");
            Department d3 = new Department(3, "Qualidade");
            Department d4 = new Department(4, "Suporte");

            Seller s1 = new Seller(1, "Maria Silva", "maria.silva@salesmvc.com", new DateTime(1991, 9, 25), 10.000, d1);
            Seller s2 = new Seller(1, "João Souza", "joao.souza@salesmvc.com", new DateTime(1992, 8, 26), 10.000, d2);
            Seller s3 = new Seller(1, "Pedro Carvalho", "pedro.carvalho@salesmvc.com", new DateTime(1993, 11, 27), 10.000, d3);
            Seller s4 = new Seller(1, "José Santos", "jose.santos@salesmvc.com", new DateTime(1984, 12, 28), 10.000, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 11, 1), 10000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 11, 2), 10000.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 11, 3), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 11, 3), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 11, 3), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 11, 4), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 11, 4), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 11, 5), 10000.0, SalesStatus.Billed, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 11, 6), 10000.0, SalesStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 11, 7), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 11, 7), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 11, 7), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 11, 7), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 11, 7), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 11, 8), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 11, 8), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 11, 8), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 11, 9), 10000.0, SalesStatus.Billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 11, 9), 10000.0, SalesStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 11, 9), 10000.0, SalesStatus.Billed, s1);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 11, 10), 10000.0, SalesStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 11, 10), 10000.0, SalesStatus.Billed, s2);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 11, 10), 10000.0, SalesStatus.Billed, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 11, 11), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 11, 11), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 11, 11), 10000.0, SalesStatus.Billed, s3);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 11, 12), 10000.0, SalesStatus.Billed, s4);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 11, 13), 10000.0, SalesStatus.Billed, s1);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 11, 14), 10000.0, SalesStatus.Billed, s2);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 11, 15), 10000.0, SalesStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
