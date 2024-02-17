using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDepo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBLDepoTransferMas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CikisDepo = table.Column<short>(type: "smallint", nullable: false),
                    VarisDepo = table.Column<short>(type: "smallint", nullable: false),
                    CariKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BelgeSeri = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EIrsaliyeMi = table.Column<bool>(type: "bit", nullable: false),
                    UretimIsEmriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SiparisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsEmriTamamlandiMi = table.Column<bool>(type: "bit", nullable: false),
                    NetsiseAtildiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLDepoTransferMas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLDepoTransferTalep",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoTransferMasId = table.Column<long>(type: "bigint", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Miktar = table.Column<double>(type: "double(30,8)", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OnayDurumu = table.Column<bool>(type: "bit", nullable: false),
                    OnaylamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLDepoTransferTalep", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLDepoTransferTra",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoTransferMasId = table.Column<long>(type: "bigint", nullable: false),
                    EtiketId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLDepoTransferTra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLEIrsaliyeDepoTanimi",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CikisDepo = table.Column<short>(type: "smallint", nullable: false),
                    VarisDepo = table.Column<short>(type: "smallint", nullable: false),
                    CariKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLEIrsaliyeDepoTanimi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLEtiket",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Etiket = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Miktar = table.Column<double>(type: "double(30,8)", nullable: false),
                    KoliEtiketi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaletEtiketi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Skt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gkk = table.Column<short>(type: "smallint", nullable: false),
                    AnaEtiket = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MalKabulEtiketi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PartiNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RafEtiketi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepodaMi = table.Column<bool>(type: "bit", nullable: false),
                    DepoKodu = table.Column<short>(type: "smallint", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLEtiket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLEtiketGecmisi",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnaEtiketId = table.Column<long>(type: "bigint", nullable: false),
                    OlusanEtiketId = table.Column<long>(type: "bigint", nullable: false),
                    AnaEtiketMiktari = table.Column<double>(type: "double(18,2)", nullable: false),
                    OlusanEtiketMiktari = table.Column<double>(type: "double(18,2)", nullable: false),
                    AnaDepoKodu = table.Column<short>(type: "smallint", nullable: false),
                    OlusanDepoKodu = table.Column<short>(type: "smallint", nullable: false),
                    IslemTipi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLEtiketGecmisi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLIrsaliyeSiparisEsleme",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IrsaliyeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SiparisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IrsaliyeTipi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MalKabulId = table.Column<long>(type: "bigint", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLIrsaliyeSiparisEsleme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLKullaniciSirketEsleme",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLKullaniciSirketEsleme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLMalKabul",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Etiket = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Skt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PartiNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepoKodu = table.Column<int>(type: "int", nullable: false),
                    IrsaliyeNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NetsiseAtildiMi = table.Column<bool>(type: "bit", nullable: false),
                    silindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLMalKabul", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLOnayliDatDepoTanimlama",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CikisDepo = table.Column<short>(type: "smallint", nullable: false),
                    VarisDepo = table.Column<short>(type: "smallint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLOnayliDatDepoTanimlama", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLRaf",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoKodu = table.Column<short>(type: "smallint", nullable: false),
                    RafEtiket = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RafKodu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ust = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sag = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sol = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaxRafAgirligi = table.Column<double>(type: "double(18,2)", nullable: false),
                    RafHacmi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLRaf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLRecete",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StokKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Miktar = table.Column<double>(type: "double(30,8)", nullable: false),
                    UskId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLRecete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLSevkMas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CikisDepo = table.Column<short>(type: "smallint", nullable: false),
                    CariKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BelgeSeri = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsEmriTamamlandiMi = table.Column<bool>(type: "bit", nullable: false),
                    NetsiseAtildiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLSevkMas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLSevkTalep",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SevkId = table.Column<long>(type: "bigint", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Miktar = table.Column<double>(type: "double(30,8)", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SiparisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KalemSiraNo = table.Column<int>(type: "int", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLSevkTalep", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLSevkTra",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SevkId = table.Column<long>(type: "bigint", nullable: false),
                    EtiketId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLSevkTra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLSirketler",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketDBAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SirketDBIp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SirketDBKullaniciAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SirketDBSifre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLSirketler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLTerminal",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerminalNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLTerminal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLTerminalUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TerminalId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLTerminalUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLUretimMas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CikisDepo = table.Column<short>(type: "smallint", nullable: false),
                    VarisDepo = table.Column<short>(type: "smallint", nullable: false),
                    BelgeSeri = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    UretimIsEmriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsEmriTamamlandiMi = table.Column<bool>(type: "bit", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLUretimMas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLUretimTalep",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimMasId = table.Column<long>(type: "bigint", nullable: false),
                    StokKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Miktar = table.Column<double>(type: "double(30,8)", nullable: false),
                    SeriNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OnayDurumu = table.Column<bool>(type: "bit", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLUretimTalep", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLUretimTra",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimMasId = table.Column<long>(type: "bigint", nullable: false),
                    EtiketId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLUretimTra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLUser",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eposta = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLUsk",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EtiketId = table.Column<long>(type: "bigint", nullable: false),
                    UretimDepo = table.Column<short>(type: "smallint", nullable: false),
                    BelgeSeri = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsEmriNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsEmriId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    NetsiseAtildiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLUsk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBLUskTuketim",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EtiketId = table.Column<long>(type: "bigint", nullable: false),
                    Miktar = table.Column<double>(type: "double(30,8)", nullable: false),
                    UskId = table.Column<long>(type: "bigint", nullable: false),
                    SilindiMi = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullaniciId = table.Column<long>(type: "bigint", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SilenKullaniciId = table.Column<long>(type: "bigint", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SirketKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLUskTuketim", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBLDepoTransferMas");

            migrationBuilder.DropTable(
                name: "TBLDepoTransferTalep");

            migrationBuilder.DropTable(
                name: "TBLDepoTransferTra");

            migrationBuilder.DropTable(
                name: "TBLEIrsaliyeDepoTanimi");

            migrationBuilder.DropTable(
                name: "TBLEtiket");

            migrationBuilder.DropTable(
                name: "TBLEtiketGecmisi");

            migrationBuilder.DropTable(
                name: "TBLIrsaliyeSiparisEsleme");

            migrationBuilder.DropTable(
                name: "TBLKullaniciSirketEsleme");

            migrationBuilder.DropTable(
                name: "TBLMalKabul");

            migrationBuilder.DropTable(
                name: "TBLOnayliDatDepoTanimlama");

            migrationBuilder.DropTable(
                name: "TBLRaf");

            migrationBuilder.DropTable(
                name: "TBLRecete");

            migrationBuilder.DropTable(
                name: "TBLSevkMas");

            migrationBuilder.DropTable(
                name: "TBLSevkTalep");

            migrationBuilder.DropTable(
                name: "TBLSevkTra");

            migrationBuilder.DropTable(
                name: "TBLSirketler");

            migrationBuilder.DropTable(
                name: "TBLTerminal");

            migrationBuilder.DropTable(
                name: "TBLTerminalUser");

            migrationBuilder.DropTable(
                name: "TBLUretimMas");

            migrationBuilder.DropTable(
                name: "TBLUretimTalep");

            migrationBuilder.DropTable(
                name: "TBLUretimTra");

            migrationBuilder.DropTable(
                name: "TBLUser");

            migrationBuilder.DropTable(
                name: "TBLUsk");

            migrationBuilder.DropTable(
                name: "TBLUskTuketim");
        }
    }
}
