using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstImagePath = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    FirstBody = table.Column<string>(type: "character varying(3000)", maxLength: 3000, nullable: false),
                    SecondImagePath = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    SecondBody = table.Column<string>(type: "character varying(3000)", maxLength: 3000, nullable: false),
                    StoryBody = table.Column<string>(type: "character varying(3000)", maxLength: 3000, nullable: false),
                    MetaTitle = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    MetaDescription = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    MetaKeys = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LanguageKey = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MapX = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    MapY = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Phone = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    TikTokAddress = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    FacebookAddress = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    LinkedinAddress = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    InstagramAddress = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    WhatsappNumber = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CustomerEmail = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CustomerPhone = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Message = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    SpecialOrder = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Subtitle = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ImagePath = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LanguageKey = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ImagePath = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    LanguageKey = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextTranslations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ContactUsId = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(3000)", maxLength: 3000, nullable: false),
                    WorkingHours = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    MetaTitle = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    MetaDescription = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    MetaKeys = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LanguageKey = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactUsTranslations_ContactUs_ContactUsId",
                        column: x => x.ContactUsId,
                        principalTable: "ContactUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LanguageKey = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategoryTranslations_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImagePath = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    SpecialOrder = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SliderImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SliderId = table.Column<Guid>(type: "uuid", nullable: false),
                    ImagePath = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SliderImages_Sliders_SliderId",
                        column: x => x.SliderId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SliderTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SliderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Subtitle = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LanguageKey = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SliderTranslations_Sliders_SliderId",
                        column: x => x.SliderId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTranslations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    ShortDescription = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LanguageKey = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTranslations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstBody", "FirstImagePath", "LanguageKey", "MetaDescription", "MetaKeys", "MetaTitle", "SecondBody", "SecondImagePath", "StoryBody", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1b0d2143-b66a-41b5-85ae-c7bdc6e8ca4f"), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "", "tr", "", "", "", "", "", "", null },
                    { new Guid("3136a22e-e622-4f41-a416-cc1161483611"), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "", "ru", "", "", "", "", "", "", null },
                    { new Guid("6192bb73-9d91-4ab6-8889-bb5665ea40fd"), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "", "az", "", "", "", "", "", "", null },
                    { new Guid("782a1df2-f4a0-4a08-88fe-47f5923f7f5b"), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "", "en", "", "", "", "", "", "", null },
                    { new Guid("b3ed0380-1c80-45e8-b39e-37a43c8ae815"), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", "", "ko", "", "", "", "", "", "", null }
                });

            migrationBuilder.InsertData(
                table: "ContactUs",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Email", "FacebookAddress", "InstagramAddress", "LinkedinAddress", "MapX", "MapY", "Phone", "TikTokAddress", "UpdatedDate", "WhatsappNumber" },
                values: new object[] { new Guid("2be6044a-deea-4b46-a7a6-4beef40db34e"), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "noreply@carlog.com", "https://www.facebook.com/", "https://www.instagram.com/", "https://linkedin.com/", "40.409264", "49.867092", "+99 (0) 101 0000 888", "https://tiktok.com", null, "" });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Comment", "CreatedDate", "DeletedDate", "Key", "Type", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { new Guid("13b2dfc9-d575-4c65-8004-0564fc366a79"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_cover_image", 4, null, "/assets/img/hero/about.jpg" },
                    { new Guid("16324835-e330-4ab8-b85d-0c7592606af8"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_cover_image", 4, null, "/assets/img/hero/about.jpg" },
                    { new Guid("2b0a5d20-acff-4a78-a80b-ab7e0f61ba1d"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_cover_image", 4, null, "/assets/img/hero/h1_hero.jpg" },
                    { new Guid("38650ea9-d9a1-4d99-9f1c-97dd80b2cb48"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "blog_single_cover_image", 4, null, "/assets/img/hero/about.jpg" },
                    { new Guid("490ed2ac-ddaf-4cc3-9d63-17d3522f4823"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_logo_width", 1, null, "100" },
                    { new Guid("575911e7-7965-4aaf-9731-2d1289b81158"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "favicon_logo", 4, null, "favicon_logo" },
                    { new Guid("5f552a26-2170-40a0-8c86-dd2263b53d80"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "blogs_cover_image", 4, null, "/assets/img/hero/about.jpg" },
                    { new Guid("632a5639-59c9-4922-a8ec-145b6d23631d"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_logo", 4, null, "header_logo" },
                    { new Guid("6414c07a-5c40-4dc6-bdfa-3f32e5e97812"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_logo_width", 1, null, "100" },
                    { new Guid("671793b5-50b0-4641-aa38-87feade86ac1"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_cover_image", 4, null, "/assets/img/hero/about.jpg" },
                    { new Guid("89128ca6-006d-4216-bf9d-48e932006ccc"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_cover_image", 4, null, "/assets/img/hero/about.jpg" },
                    { new Guid("8a8bfa84-2c93-4055-a4c5-00ac6b35aec2"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_logo_height", 1, null, "100" },
                    { new Guid("ae7654ac-63ca-432d-908d-5c738f2b5ddd"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "main_color", 2, null, "#03A297" },
                    { new Guid("b76612b2-d3f8-4bb2-a3f6-996be9fdd628"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "third_color", 2, null, "#ffffff" },
                    { new Guid("bababe10-ee71-44a1-ada3-f41253b1f316"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_logo", 4, null, "footer_logo" },
                    { new Guid("c4dc12b4-50a0-4fc6-bd5c-d33216149c23"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_logo_height", 1, null, "100" },
                    { new Guid("d8605837-50ca-49f9-9ef7-a06f7db10ac5"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_single_cover_image", 4, null, "/assets/img/hero/about.jpg" },
                    { new Guid("f194dffe-82fa-42e3-8528-ebeced4d48cd"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "secondary_color", 2, null, "#023350" },
                    { new Guid("ffcffbbe-9f1f-4bbf-bbb9-912573bdba38"), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_cover_image", 4, null, "/assets/img/hero/about.jpg" }
                });

            migrationBuilder.InsertData(
                table: "TextTranslations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Key", "LanguageKey", "Type", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_to_cart", "ko", 2, null, "add_to_cart" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "loading_title", "ko", 2, null, "loading_title" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "view_more_button", "ko", 2, null, "view_more_button" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "follow_us_title", "ko", 2, null, "header_follow_us_title" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_title", "ko", 2, null, "header_whatsapp_title" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_sub_title", "ko", 2, null, "header_whatsapp_sub_title" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_my_cart_title", "ko", 2, null, "header_my_cart_title" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_is_empty", "ko", 2, null, "header_cart_is_empty" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_total", "ko", 2, null, "header_cart_total" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_checkout_button", "ko", 2, null, "header_cart_checkout_button" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_all_categories", "ko", 2, null, "header_all_categories" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_search_here", "ko", 2, null, "header_search_here" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_search_here", "ko", 2, null, "header_cart_search_here" },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_extra_pages", "ko", 2, null, "header_extra_pages" },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_title", "ko", 3, null, "footer_title" },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_copyright", "ko", 2, null, "footer_copyright" },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_link_list", "ko", 2, null, "footer_link_list" },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_category_list", "ko", 2, null, "footer_category_list" },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_extra_page_list", "ko", 2, null, "footer_extra_page_list" },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "added_cart_title", "ko", 2, null, "added_cart_title" },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_title", "ko", 2, null, "home_page_title" },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_title", "ko", 2, null, "home_our_speciality_title" },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_subtitle", "ko", 2, null, "home_our_speciality_subtitle" },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_title", "ko", 2, null, "home_our_speciality_menu_title" },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_subtitle", "ko", 2, null, "home_our_speciality_menu_subtitle" },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_latest_products_title", "ko", 2, null, "home_latest_products_title" },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_title", "ko", 2, null, "home_our_blogs_title" },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_subtitle", "ko", 2, null, "home_our_blogs_subtitle" },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_description_meta", "ko", 2, null, "home_page_description_meta" },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_header_title", "ko", 2, null, "home_page_header_title" },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_keywords_meta", "ko", 2, null, "home_page_keywords_meta" },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_page_title", "ko", 2, null, "menu_page_title" },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "all_category_title", "ko", 2, null, "all_category_title" },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_description_meta", "ko", 2, null, "menu_description_meta" },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_header_title", "ko", 2, null, "menu_header_title" },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_keywords_meta", "ko", 2, null, "menu_keywords_meta" },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_page_title", "ko", 2, null, "about_us_page_title" },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_title", "ko", 2, null, "about_us_our_team_title" },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_subtitle", "ko", 2, null, "about_us_our_team_subtitle" },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_partners_title", "ko", 2, null, "about_us_partners_title" },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_description_meta", "ko", 2, null, "about_us_description_meta" },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_header_title", "ko", 2, null, "about_us_header_title" },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_keywords_meta", "ko", 2, null, "about_us_keywords_meta" },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_page_title", "ko", 2, null, "our_blogs_page_title" },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_title", "ko", 2, null, "our_blogs_title" },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_subtitle", "ko", 2, null, "our_blogs_subtitle" },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_read_more_button", "ko", 2, null, "our_blogs_read_more_button" },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_description_meta", "ko", 2, null, "our_blogs_description_meta" },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_header_title", "ko", 2, null, "our_blogs_header_title" },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_keywords_meta", "ko", 2, null, "our_blogs_keywords_meta" },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_blog_tags", "ko", 2, null, "single_blog_tags" },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_page_title", "ko", 2, null, "contact_us_page_title" },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_address_title", "ko", 2, null, "contact_us_address_title" },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_call_us_title", "ko", 2, null, "contact_us_call_us_title" },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_email_us_title", "ko", 2, null, "contact_us_email_us_title" },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_open_time_title", "ko", 2, null, "contact_us_open_time_title" },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_title", "ko", 2, null, "contact_us_get_in_touch_title" },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_subtitle", "ko", 2, null, "contact_us_get_in_touch_subtitle" },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_button", "ko", 2, null, "contact_us_get_in_touch_button" },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_name_placeholder", "ko", 2, null, "contact_us_get_in_touch_your_name_placeholder" },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_email_placeholder", "ko", 2, null, "contact_us_get_in_touch_your_email_placeholder" },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_phone_placeholder", "ko", 2, null, "contact_us_get_in_touch_your_phone_placeholder" },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_subject_placeholder", "ko", 2, null, "contact_us_get_in_touch_your_subject_placeholder" },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_message_placeholder", "ko", 2, null, "contact_us_get_in_touch_your_message_placeholder" },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_description_meta", "ko", 2, null, "contact_us_description_meta" },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_header_title", "ko", 2, null, "contact_us_header_title" },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_keywords_meta", "ko", 2, null, "contact_us_keywords_meta" },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_title", "ko", 2, null, "faq_page_title" },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_description_meta", "ko", 2, null, "faq_page_description_meta" },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_header_title", "ko", 2, null, "faq_page_header_title" },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_keywords_meta", "ko", 2, null, "faq_page_keywords_meta" },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_title", "ko", 2, null, "products_page_title" },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_category_title", "ko", 2, null, "products_filter_category_title" },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_brands_title", "ko", 2, null, "products_filter_brands_title" },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_price_range_title", "ko", 2, null, "products_filter_price_range_title" },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_search_button", "ko", 2, null, "products_filter_search_button" },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_title", "ko", 2, null, "products_sort_by_title" },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_latest_items_option", "ko", 2, null, "products_sort_by_latest_items_option" },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_best_seller_items_option", "ko", 2, null, "products_sort_by_best_seller_items_option" },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_low_to_high_option", "ko", 2, null, "products_sort_by_price_low_to_high_option" },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_high_to_low_option", "ko", 2, null, "products_sort_by_price_high_to_low_option" },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_description_meta", "ko", 2, null, "products_page_description_meta" },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_header_title", "ko", 2, null, "products_page_header_title" },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_keywords_meta", "ko", 2, null, "products_page_keywords_meta" },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_quantity_title", "ko", 2, null, "single_product_quantity_title" },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_sku_title", "ko", 2, null, "single_product_sku_title" },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_category_title", "ko", 2, null, "single_product_category_title" },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_brand_title", "ko", 2, null, "single_product_brand_title" },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_tags_title", "ko", 2, null, "single_product_tags_title" },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_description_title", "ko", 2, null, "single_product_description_title" },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_additional_info_title", "ko", 2, null, "single_product_additional_info_title" },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_documents_title", "ko", 2, null, "single_product_documents_title" },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_related_items_title", "ko", 2, null, "single_product_related_items_title" },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_title", "ko", 2, null, "orders_page_title" },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_title", "ko", 2, null, "orders_page_your_orders_title" },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_title", "ko", 2, null, "orders_page_your_informations_title" },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_image_th", "ko", 2, null, "orders_page_your_orders_image_th" },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_name_th", "ko", 2, null, "orders_page_your_orders_name_th" },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_price_th", "ko", 2, null, "orders_page_your_orders_price_th" },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_quantity_th", "ko", 2, null, "orders_page_your_orders_quantity_th" },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_subtotal_th", "ko", 2, null, "orders_page_your_orders_subtotal_th" },
                    { 102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_category", "ko", 2, null, "orders_page_your_products_category" },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_brand", "ko", 2, null, "orders_page_your_products_brand" },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_title", "ko", 2, null, "orders_page_your_informations_first_name_title" },
                    { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_placeholder", "ko", 2, null, "orders_page_your_informations_first_name_placeholder" },
                    { 106, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_title", "ko", 2, null, "orders_page_your_informations_last_name_title" },
                    { 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_placeholder", "ko", 2, null, "orders_page_your_informations_last_name_placeholder" },
                    { 108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_title", "ko", 2, null, "orders_page_your_informations_email_title" },
                    { 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_placeholder", "ko", 2, null, "orders_page_your_informations_email_placeholder" },
                    { 110, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_title", "ko", 2, null, "orders_page_your_informations_phone_title" },
                    { 111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_placeholder", "ko", 2, null, "orders_page_your_informations_phone_placeholder" },
                    { 112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_title", "ko", 2, null, "orders_page_your_informations_address_title" },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_placeholder", "ko", 2, null, "orders_page_your_informations_address_placeholder" },
                    { 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_description_title", "ko", 2, null, "orders_page_your_informations_description_title" },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_title", "ko", 2, null, "orders_page_your_cart_summary_title" },
                    { 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_subtotal", "ko", 2, null, "orders_page_your_cart_summary_subtotal" },
                    { 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_discount", "ko", 2, null, "orders_page_your_cart_summary_discount" },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_totalPrice", "ko", 2, null, "orders_page_your_cart_summary_totalPrice" },
                    { 119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_checkout_now", "ko", 2, null, "orders_page_your_cart_summary_checkout_now" },
                    { 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_title", "ko", 2, null, "orders_page_your_cart_is_empty_title" },
                    { 121, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_subtitle", "ko", 2, null, "orders_page_your_cart_is_empty_subtitle" },
                    { 122, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_go_back_home_button", "ko", 2, null, "orders_page_your_cart_is_empty_go_back_home_button" },
                    { 123, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message_title", "ko", 2, null, "success_message_title" },
                    { 124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message", "ko", 2, null, "success_message" },
                    { 125, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message_title", "ko", 2, null, "error_message_title" },
                    { 126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message", "ko", 2, null, "error_message" },
                    { 127, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_in_cart_message", "ko", 2, null, "add_in_cart_message" },
                    { 128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message_title", "ko", 2, null, "success_order_message_title" },
                    { 129, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message", "ko", 2, null, "success_order_message" },
                    { 130, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_to_cart", "en", 2, null, "add_to_cart" },
                    { 131, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "loading_title", "en", 2, null, "loading_title" },
                    { 132, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "view_more_button", "en", 2, null, "view_more_button" },
                    { 133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "follow_us_title", "en", 2, null, "header_follow_us_title" },
                    { 134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_title", "en", 2, null, "header_whatsapp_title" },
                    { 135, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_sub_title", "en", 2, null, "header_whatsapp_sub_title" },
                    { 136, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_my_cart_title", "en", 2, null, "header_my_cart_title" },
                    { 137, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_is_empty", "en", 2, null, "header_cart_is_empty" },
                    { 138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_total", "en", 2, null, "header_cart_total" },
                    { 139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_checkout_button", "en", 2, null, "header_cart_checkout_button" },
                    { 140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_all_categories", "en", 2, null, "header_all_categories" },
                    { 141, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_search_here", "en", 2, null, "header_search_here" },
                    { 142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_search_here", "en", 2, null, "header_cart_search_here" },
                    { 143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_extra_pages", "en", 2, null, "header_extra_pages" },
                    { 144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_title", "en", 3, null, "footer_title" },
                    { 145, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_copyright", "en", 2, null, "footer_copyright" },
                    { 146, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_link_list", "en", 2, null, "footer_link_list" },
                    { 147, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_category_list", "en", 2, null, "footer_category_list" },
                    { 148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_extra_page_list", "en", 2, null, "footer_extra_page_list" },
                    { 149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "added_cart_title", "en", 2, null, "added_cart_title" },
                    { 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_title", "en", 2, null, "home_page_title" },
                    { 151, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_title", "en", 2, null, "home_our_speciality_title" },
                    { 152, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_subtitle", "en", 2, null, "home_our_speciality_subtitle" },
                    { 153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_title", "en", 2, null, "home_our_speciality_menu_title" },
                    { 154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_subtitle", "en", 2, null, "home_our_speciality_menu_subtitle" },
                    { 155, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_latest_products_title", "en", 2, null, "home_latest_products_title" },
                    { 156, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_title", "en", 2, null, "home_our_blogs_title" },
                    { 157, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_subtitle", "en", 2, null, "home_our_blogs_subtitle" },
                    { 158, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_description_meta", "en", 2, null, "home_page_description_meta" },
                    { 159, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_header_title", "en", 2, null, "home_page_header_title" },
                    { 160, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_keywords_meta", "en", 2, null, "home_page_keywords_meta" },
                    { 161, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_page_title", "en", 2, null, "menu_page_title" },
                    { 162, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "all_category_title", "en", 2, null, "all_category_title" },
                    { 163, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_description_meta", "en", 2, null, "menu_description_meta" },
                    { 164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_header_title", "en", 2, null, "menu_header_title" },
                    { 165, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_keywords_meta", "en", 2, null, "menu_keywords_meta" },
                    { 166, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_page_title", "en", 2, null, "about_us_page_title" },
                    { 167, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_title", "en", 2, null, "about_us_our_team_title" },
                    { 168, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_subtitle", "en", 2, null, "about_us_our_team_subtitle" },
                    { 169, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_partners_title", "en", 2, null, "about_us_partners_title" },
                    { 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_description_meta", "en", 2, null, "about_us_description_meta" },
                    { 171, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_header_title", "en", 2, null, "about_us_header_title" },
                    { 172, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_keywords_meta", "en", 2, null, "about_us_keywords_meta" },
                    { 173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_page_title", "en", 2, null, "our_blogs_page_title" },
                    { 174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_title", "en", 2, null, "our_blogs_title" },
                    { 175, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_subtitle", "en", 2, null, "our_blogs_subtitle" },
                    { 176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_read_more_button", "en", 2, null, "our_blogs_read_more_button" },
                    { 177, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_description_meta", "en", 2, null, "our_blogs_description_meta" },
                    { 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_header_title", "en", 2, null, "our_blogs_header_title" },
                    { 179, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_keywords_meta", "en", 2, null, "our_blogs_keywords_meta" },
                    { 180, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_blog_tags", "en", 2, null, "single_blog_tags" },
                    { 181, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_page_title", "en", 2, null, "contact_us_page_title" },
                    { 182, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_address_title", "en", 2, null, "contact_us_address_title" },
                    { 183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_call_us_title", "en", 2, null, "contact_us_call_us_title" },
                    { 184, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_email_us_title", "en", 2, null, "contact_us_email_us_title" },
                    { 185, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_open_time_title", "en", 2, null, "contact_us_open_time_title" },
                    { 186, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_title", "en", 2, null, "contact_us_get_in_touch_title" },
                    { 187, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_subtitle", "en", 2, null, "contact_us_get_in_touch_subtitle" },
                    { 188, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_button", "en", 2, null, "contact_us_get_in_touch_button" },
                    { 189, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_name_placeholder", "en", 2, null, "contact_us_get_in_touch_your_name_placeholder" },
                    { 190, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_email_placeholder", "en", 2, null, "contact_us_get_in_touch_your_email_placeholder" },
                    { 191, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_phone_placeholder", "en", 2, null, "contact_us_get_in_touch_your_phone_placeholder" },
                    { 192, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_subject_placeholder", "en", 2, null, "contact_us_get_in_touch_your_subject_placeholder" },
                    { 193, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_message_placeholder", "en", 2, null, "contact_us_get_in_touch_your_message_placeholder" },
                    { 194, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_description_meta", "en", 2, null, "contact_us_description_meta" },
                    { 195, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_header_title", "en", 2, null, "contact_us_header_title" },
                    { 196, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_keywords_meta", "en", 2, null, "contact_us_keywords_meta" },
                    { 197, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_title", "en", 2, null, "faq_page_title" },
                    { 198, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_description_meta", "en", 2, null, "faq_page_description_meta" },
                    { 199, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_header_title", "en", 2, null, "faq_page_header_title" },
                    { 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_keywords_meta", "en", 2, null, "faq_page_keywords_meta" },
                    { 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_title", "en", 2, null, "products_page_title" },
                    { 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_category_title", "en", 2, null, "products_filter_category_title" },
                    { 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_brands_title", "en", 2, null, "products_filter_brands_title" },
                    { 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_price_range_title", "en", 2, null, "products_filter_price_range_title" },
                    { 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_search_button", "en", 2, null, "products_filter_search_button" },
                    { 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_title", "en", 2, null, "products_sort_by_title" },
                    { 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_latest_items_option", "en", 2, null, "products_sort_by_latest_items_option" },
                    { 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_best_seller_items_option", "en", 2, null, "products_sort_by_best_seller_items_option" },
                    { 209, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_low_to_high_option", "en", 2, null, "products_sort_by_price_low_to_high_option" },
                    { 210, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_high_to_low_option", "en", 2, null, "products_sort_by_price_high_to_low_option" },
                    { 211, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_description_meta", "en", 2, null, "products_page_description_meta" },
                    { 212, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_header_title", "en", 2, null, "products_page_header_title" },
                    { 213, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_keywords_meta", "en", 2, null, "products_page_keywords_meta" },
                    { 214, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_quantity_title", "en", 2, null, "single_product_quantity_title" },
                    { 215, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_sku_title", "en", 2, null, "single_product_sku_title" },
                    { 216, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_category_title", "en", 2, null, "single_product_category_title" },
                    { 217, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_brand_title", "en", 2, null, "single_product_brand_title" },
                    { 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_tags_title", "en", 2, null, "single_product_tags_title" },
                    { 219, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_description_title", "en", 2, null, "single_product_description_title" },
                    { 220, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_additional_info_title", "en", 2, null, "single_product_additional_info_title" },
                    { 221, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_documents_title", "en", 2, null, "single_product_documents_title" },
                    { 222, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_related_items_title", "en", 2, null, "single_product_related_items_title" },
                    { 223, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_title", "en", 2, null, "orders_page_title" },
                    { 224, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_title", "en", 2, null, "orders_page_your_orders_title" },
                    { 225, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_title", "en", 2, null, "orders_page_your_informations_title" },
                    { 226, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_image_th", "en", 2, null, "orders_page_your_orders_image_th" },
                    { 227, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_name_th", "en", 2, null, "orders_page_your_orders_name_th" },
                    { 228, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_price_th", "en", 2, null, "orders_page_your_orders_price_th" },
                    { 229, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_quantity_th", "en", 2, null, "orders_page_your_orders_quantity_th" },
                    { 230, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_subtotal_th", "en", 2, null, "orders_page_your_orders_subtotal_th" },
                    { 231, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_category", "en", 2, null, "orders_page_your_products_category" },
                    { 232, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_brand", "en", 2, null, "orders_page_your_products_brand" },
                    { 233, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_title", "en", 2, null, "orders_page_your_informations_first_name_title" },
                    { 234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_placeholder", "en", 2, null, "orders_page_your_informations_first_name_placeholder" },
                    { 235, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_title", "en", 2, null, "orders_page_your_informations_last_name_title" },
                    { 236, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_placeholder", "en", 2, null, "orders_page_your_informations_last_name_placeholder" },
                    { 237, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_title", "en", 2, null, "orders_page_your_informations_email_title" },
                    { 238, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_placeholder", "en", 2, null, "orders_page_your_informations_email_placeholder" },
                    { 239, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_title", "en", 2, null, "orders_page_your_informations_phone_title" },
                    { 240, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_placeholder", "en", 2, null, "orders_page_your_informations_phone_placeholder" },
                    { 241, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_title", "en", 2, null, "orders_page_your_informations_address_title" },
                    { 242, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_placeholder", "en", 2, null, "orders_page_your_informations_address_placeholder" },
                    { 243, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_description_title", "en", 2, null, "orders_page_your_informations_description_title" },
                    { 244, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_title", "en", 2, null, "orders_page_your_cart_summary_title" },
                    { 245, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_subtotal", "en", 2, null, "orders_page_your_cart_summary_subtotal" },
                    { 246, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_discount", "en", 2, null, "orders_page_your_cart_summary_discount" },
                    { 247, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_totalPrice", "en", 2, null, "orders_page_your_cart_summary_totalPrice" },
                    { 248, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_checkout_now", "en", 2, null, "orders_page_your_cart_summary_checkout_now" },
                    { 249, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_title", "en", 2, null, "orders_page_your_cart_is_empty_title" },
                    { 250, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_subtitle", "en", 2, null, "orders_page_your_cart_is_empty_subtitle" },
                    { 251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_go_back_home_button", "en", 2, null, "orders_page_your_cart_is_empty_go_back_home_button" },
                    { 252, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message_title", "en", 2, null, "success_message_title" },
                    { 253, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message", "en", 2, null, "success_message" },
                    { 254, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message_title", "en", 2, null, "error_message_title" },
                    { 255, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message", "en", 2, null, "error_message" },
                    { 256, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_in_cart_message", "en", 2, null, "add_in_cart_message" },
                    { 257, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message_title", "en", 2, null, "success_order_message_title" },
                    { 258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message", "en", 2, null, "success_order_message" },
                    { 259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_to_cart", "az", 2, null, "add_to_cart" },
                    { 260, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "loading_title", "az", 2, null, "loading_title" },
                    { 261, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "view_more_button", "az", 2, null, "view_more_button" },
                    { 262, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "follow_us_title", "az", 2, null, "header_follow_us_title" },
                    { 263, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_title", "az", 2, null, "header_whatsapp_title" },
                    { 264, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_sub_title", "az", 2, null, "header_whatsapp_sub_title" },
                    { 265, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_my_cart_title", "az", 2, null, "header_my_cart_title" },
                    { 266, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_is_empty", "az", 2, null, "header_cart_is_empty" },
                    { 267, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_total", "az", 2, null, "header_cart_total" },
                    { 268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_checkout_button", "az", 2, null, "header_cart_checkout_button" },
                    { 269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_all_categories", "az", 2, null, "header_all_categories" },
                    { 270, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_search_here", "az", 2, null, "header_search_here" },
                    { 271, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_search_here", "az", 2, null, "header_cart_search_here" },
                    { 272, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_extra_pages", "az", 2, null, "header_extra_pages" },
                    { 273, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_title", "az", 3, null, "footer_title" },
                    { 274, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_copyright", "az", 2, null, "footer_copyright" },
                    { 275, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_link_list", "az", 2, null, "footer_link_list" },
                    { 276, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_category_list", "az", 2, null, "footer_category_list" },
                    { 277, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_extra_page_list", "az", 2, null, "footer_extra_page_list" },
                    { 278, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "added_cart_title", "az", 2, null, "added_cart_title" },
                    { 279, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_title", "az", 2, null, "home_page_title" },
                    { 280, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_title", "az", 2, null, "home_our_speciality_title" },
                    { 281, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_subtitle", "az", 2, null, "home_our_speciality_subtitle" },
                    { 282, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_title", "az", 2, null, "home_our_speciality_menu_title" },
                    { 283, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_subtitle", "az", 2, null, "home_our_speciality_menu_subtitle" },
                    { 284, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_latest_products_title", "az", 2, null, "home_latest_products_title" },
                    { 285, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_title", "az", 2, null, "home_our_blogs_title" },
                    { 286, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_subtitle", "az", 2, null, "home_our_blogs_subtitle" },
                    { 287, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_description_meta", "az", 2, null, "home_page_description_meta" },
                    { 288, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_header_title", "az", 2, null, "home_page_header_title" },
                    { 289, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_keywords_meta", "az", 2, null, "home_page_keywords_meta" },
                    { 290, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_page_title", "az", 2, null, "menu_page_title" },
                    { 291, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "all_category_title", "az", 2, null, "all_category_title" },
                    { 292, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_description_meta", "az", 2, null, "menu_description_meta" },
                    { 293, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_header_title", "az", 2, null, "menu_header_title" },
                    { 294, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_keywords_meta", "az", 2, null, "menu_keywords_meta" },
                    { 295, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_page_title", "az", 2, null, "about_us_page_title" },
                    { 296, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_title", "az", 2, null, "about_us_our_team_title" },
                    { 297, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_subtitle", "az", 2, null, "about_us_our_team_subtitle" },
                    { 298, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_partners_title", "az", 2, null, "about_us_partners_title" },
                    { 299, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_description_meta", "az", 2, null, "about_us_description_meta" },
                    { 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_header_title", "az", 2, null, "about_us_header_title" },
                    { 301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_keywords_meta", "az", 2, null, "about_us_keywords_meta" },
                    { 302, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_page_title", "az", 2, null, "our_blogs_page_title" },
                    { 303, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_title", "az", 2, null, "our_blogs_title" },
                    { 304, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_subtitle", "az", 2, null, "our_blogs_subtitle" },
                    { 305, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_read_more_button", "az", 2, null, "our_blogs_read_more_button" },
                    { 306, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_description_meta", "az", 2, null, "our_blogs_description_meta" },
                    { 307, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_header_title", "az", 2, null, "our_blogs_header_title" },
                    { 308, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_keywords_meta", "az", 2, null, "our_blogs_keywords_meta" },
                    { 309, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_blog_tags", "az", 2, null, "single_blog_tags" },
                    { 310, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_page_title", "az", 2, null, "contact_us_page_title" },
                    { 311, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_address_title", "az", 2, null, "contact_us_address_title" },
                    { 312, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_call_us_title", "az", 2, null, "contact_us_call_us_title" },
                    { 313, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_email_us_title", "az", 2, null, "contact_us_email_us_title" },
                    { 314, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_open_time_title", "az", 2, null, "contact_us_open_time_title" },
                    { 315, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_title", "az", 2, null, "contact_us_get_in_touch_title" },
                    { 316, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_subtitle", "az", 2, null, "contact_us_get_in_touch_subtitle" },
                    { 317, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_button", "az", 2, null, "contact_us_get_in_touch_button" },
                    { 318, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_name_placeholder", "az", 2, null, "contact_us_get_in_touch_your_name_placeholder" },
                    { 319, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_email_placeholder", "az", 2, null, "contact_us_get_in_touch_your_email_placeholder" },
                    { 320, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_phone_placeholder", "az", 2, null, "contact_us_get_in_touch_your_phone_placeholder" },
                    { 321, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_subject_placeholder", "az", 2, null, "contact_us_get_in_touch_your_subject_placeholder" },
                    { 322, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_message_placeholder", "az", 2, null, "contact_us_get_in_touch_your_message_placeholder" },
                    { 323, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_description_meta", "az", 2, null, "contact_us_description_meta" },
                    { 324, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_header_title", "az", 2, null, "contact_us_header_title" },
                    { 325, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_keywords_meta", "az", 2, null, "contact_us_keywords_meta" },
                    { 326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_title", "az", 2, null, "faq_page_title" },
                    { 327, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_description_meta", "az", 2, null, "faq_page_description_meta" },
                    { 328, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_header_title", "az", 2, null, "faq_page_header_title" },
                    { 329, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_keywords_meta", "az", 2, null, "faq_page_keywords_meta" },
                    { 330, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_title", "az", 2, null, "products_page_title" },
                    { 331, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_category_title", "az", 2, null, "products_filter_category_title" },
                    { 332, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_brands_title", "az", 2, null, "products_filter_brands_title" },
                    { 333, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_price_range_title", "az", 2, null, "products_filter_price_range_title" },
                    { 334, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_search_button", "az", 2, null, "products_filter_search_button" },
                    { 335, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_title", "az", 2, null, "products_sort_by_title" },
                    { 336, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_latest_items_option", "az", 2, null, "products_sort_by_latest_items_option" },
                    { 337, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_best_seller_items_option", "az", 2, null, "products_sort_by_best_seller_items_option" },
                    { 338, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_low_to_high_option", "az", 2, null, "products_sort_by_price_low_to_high_option" },
                    { 339, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_high_to_low_option", "az", 2, null, "products_sort_by_price_high_to_low_option" },
                    { 340, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_description_meta", "az", 2, null, "products_page_description_meta" },
                    { 341, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_header_title", "az", 2, null, "products_page_header_title" },
                    { 342, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_keywords_meta", "az", 2, null, "products_page_keywords_meta" },
                    { 343, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_quantity_title", "az", 2, null, "single_product_quantity_title" },
                    { 344, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_sku_title", "az", 2, null, "single_product_sku_title" },
                    { 345, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_category_title", "az", 2, null, "single_product_category_title" },
                    { 346, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_brand_title", "az", 2, null, "single_product_brand_title" },
                    { 347, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_tags_title", "az", 2, null, "single_product_tags_title" },
                    { 348, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_description_title", "az", 2, null, "single_product_description_title" },
                    { 349, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_additional_info_title", "az", 2, null, "single_product_additional_info_title" },
                    { 350, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_documents_title", "az", 2, null, "single_product_documents_title" },
                    { 351, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_related_items_title", "az", 2, null, "single_product_related_items_title" },
                    { 352, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_title", "az", 2, null, "orders_page_title" },
                    { 353, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_title", "az", 2, null, "orders_page_your_orders_title" },
                    { 354, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_title", "az", 2, null, "orders_page_your_informations_title" },
                    { 355, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_image_th", "az", 2, null, "orders_page_your_orders_image_th" },
                    { 356, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_name_th", "az", 2, null, "orders_page_your_orders_name_th" },
                    { 357, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_price_th", "az", 2, null, "orders_page_your_orders_price_th" },
                    { 358, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_quantity_th", "az", 2, null, "orders_page_your_orders_quantity_th" },
                    { 359, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_subtotal_th", "az", 2, null, "orders_page_your_orders_subtotal_th" },
                    { 360, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_category", "az", 2, null, "orders_page_your_products_category" },
                    { 361, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_brand", "az", 2, null, "orders_page_your_products_brand" },
                    { 362, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_title", "az", 2, null, "orders_page_your_informations_first_name_title" },
                    { 363, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_placeholder", "az", 2, null, "orders_page_your_informations_first_name_placeholder" },
                    { 364, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_title", "az", 2, null, "orders_page_your_informations_last_name_title" },
                    { 365, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_placeholder", "az", 2, null, "orders_page_your_informations_last_name_placeholder" },
                    { 366, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_title", "az", 2, null, "orders_page_your_informations_email_title" },
                    { 367, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_placeholder", "az", 2, null, "orders_page_your_informations_email_placeholder" },
                    { 368, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_title", "az", 2, null, "orders_page_your_informations_phone_title" },
                    { 369, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_placeholder", "az", 2, null, "orders_page_your_informations_phone_placeholder" },
                    { 370, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_title", "az", 2, null, "orders_page_your_informations_address_title" },
                    { 371, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_placeholder", "az", 2, null, "orders_page_your_informations_address_placeholder" },
                    { 372, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_description_title", "az", 2, null, "orders_page_your_informations_description_title" },
                    { 373, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_title", "az", 2, null, "orders_page_your_cart_summary_title" },
                    { 374, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_subtotal", "az", 2, null, "orders_page_your_cart_summary_subtotal" },
                    { 375, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_discount", "az", 2, null, "orders_page_your_cart_summary_discount" },
                    { 376, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_totalPrice", "az", 2, null, "orders_page_your_cart_summary_totalPrice" },
                    { 377, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_checkout_now", "az", 2, null, "orders_page_your_cart_summary_checkout_now" },
                    { 378, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_title", "az", 2, null, "orders_page_your_cart_is_empty_title" },
                    { 379, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_subtitle", "az", 2, null, "orders_page_your_cart_is_empty_subtitle" },
                    { 380, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_go_back_home_button", "az", 2, null, "orders_page_your_cart_is_empty_go_back_home_button" },
                    { 381, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message_title", "az", 2, null, "success_message_title" },
                    { 382, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message", "az", 2, null, "success_message" },
                    { 383, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message_title", "az", 2, null, "error_message_title" },
                    { 384, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message", "az", 2, null, "error_message" },
                    { 385, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_in_cart_message", "az", 2, null, "add_in_cart_message" },
                    { 386, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message_title", "az", 2, null, "success_order_message_title" },
                    { 387, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message", "az", 2, null, "success_order_message" },
                    { 388, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_to_cart", "ru", 2, null, "add_to_cart" },
                    { 389, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "loading_title", "ru", 2, null, "loading_title" },
                    { 390, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "view_more_button", "ru", 2, null, "view_more_button" },
                    { 391, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "follow_us_title", "ru", 2, null, "header_follow_us_title" },
                    { 392, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_title", "ru", 2, null, "header_whatsapp_title" },
                    { 393, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_sub_title", "ru", 2, null, "header_whatsapp_sub_title" },
                    { 394, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_my_cart_title", "ru", 2, null, "header_my_cart_title" },
                    { 395, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_is_empty", "ru", 2, null, "header_cart_is_empty" },
                    { 396, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_total", "ru", 2, null, "header_cart_total" },
                    { 397, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_checkout_button", "ru", 2, null, "header_cart_checkout_button" },
                    { 398, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_all_categories", "ru", 2, null, "header_all_categories" },
                    { 399, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_search_here", "ru", 2, null, "header_search_here" },
                    { 400, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_search_here", "ru", 2, null, "header_cart_search_here" },
                    { 401, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_extra_pages", "ru", 2, null, "header_extra_pages" },
                    { 402, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_title", "ru", 3, null, "footer_title" },
                    { 403, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_copyright", "ru", 2, null, "footer_copyright" },
                    { 404, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_link_list", "ru", 2, null, "footer_link_list" },
                    { 405, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_category_list", "ru", 2, null, "footer_category_list" },
                    { 406, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_extra_page_list", "ru", 2, null, "footer_extra_page_list" },
                    { 407, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "added_cart_title", "ru", 2, null, "added_cart_title" },
                    { 408, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_title", "ru", 2, null, "home_page_title" },
                    { 409, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_title", "ru", 2, null, "home_our_speciality_title" },
                    { 410, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_subtitle", "ru", 2, null, "home_our_speciality_subtitle" },
                    { 411, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_title", "ru", 2, null, "home_our_speciality_menu_title" },
                    { 412, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_subtitle", "ru", 2, null, "home_our_speciality_menu_subtitle" },
                    { 413, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_latest_products_title", "ru", 2, null, "home_latest_products_title" },
                    { 414, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_title", "ru", 2, null, "home_our_blogs_title" },
                    { 415, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_subtitle", "ru", 2, null, "home_our_blogs_subtitle" },
                    { 416, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_description_meta", "ru", 2, null, "home_page_description_meta" },
                    { 417, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_header_title", "ru", 2, null, "home_page_header_title" },
                    { 418, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_keywords_meta", "ru", 2, null, "home_page_keywords_meta" },
                    { 419, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_page_title", "ru", 2, null, "menu_page_title" },
                    { 420, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "all_category_title", "ru", 2, null, "all_category_title" },
                    { 421, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_description_meta", "ru", 2, null, "menu_description_meta" },
                    { 422, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_header_title", "ru", 2, null, "menu_header_title" },
                    { 423, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_keywords_meta", "ru", 2, null, "menu_keywords_meta" },
                    { 424, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_page_title", "ru", 2, null, "about_us_page_title" },
                    { 425, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_title", "ru", 2, null, "about_us_our_team_title" },
                    { 426, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_subtitle", "ru", 2, null, "about_us_our_team_subtitle" },
                    { 427, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_partners_title", "ru", 2, null, "about_us_partners_title" },
                    { 428, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_description_meta", "ru", 2, null, "about_us_description_meta" },
                    { 429, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_header_title", "ru", 2, null, "about_us_header_title" },
                    { 430, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_keywords_meta", "ru", 2, null, "about_us_keywords_meta" },
                    { 431, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_page_title", "ru", 2, null, "our_blogs_page_title" },
                    { 432, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_title", "ru", 2, null, "our_blogs_title" },
                    { 433, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_subtitle", "ru", 2, null, "our_blogs_subtitle" },
                    { 434, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_read_more_button", "ru", 2, null, "our_blogs_read_more_button" },
                    { 435, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_description_meta", "ru", 2, null, "our_blogs_description_meta" },
                    { 436, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_header_title", "ru", 2, null, "our_blogs_header_title" },
                    { 437, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_keywords_meta", "ru", 2, null, "our_blogs_keywords_meta" },
                    { 438, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_blog_tags", "ru", 2, null, "single_blog_tags" },
                    { 439, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_page_title", "ru", 2, null, "contact_us_page_title" },
                    { 440, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_address_title", "ru", 2, null, "contact_us_address_title" },
                    { 441, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_call_us_title", "ru", 2, null, "contact_us_call_us_title" },
                    { 442, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_email_us_title", "ru", 2, null, "contact_us_email_us_title" },
                    { 443, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_open_time_title", "ru", 2, null, "contact_us_open_time_title" },
                    { 444, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_title", "ru", 2, null, "contact_us_get_in_touch_title" },
                    { 445, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_subtitle", "ru", 2, null, "contact_us_get_in_touch_subtitle" },
                    { 446, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_button", "ru", 2, null, "contact_us_get_in_touch_button" },
                    { 447, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_name_placeholder", "ru", 2, null, "contact_us_get_in_touch_your_name_placeholder" },
                    { 448, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_email_placeholder", "ru", 2, null, "contact_us_get_in_touch_your_email_placeholder" },
                    { 449, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_phone_placeholder", "ru", 2, null, "contact_us_get_in_touch_your_phone_placeholder" },
                    { 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_subject_placeholder", "ru", 2, null, "contact_us_get_in_touch_your_subject_placeholder" },
                    { 451, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_message_placeholder", "ru", 2, null, "contact_us_get_in_touch_your_message_placeholder" },
                    { 452, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_description_meta", "ru", 2, null, "contact_us_description_meta" },
                    { 453, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_header_title", "ru", 2, null, "contact_us_header_title" },
                    { 454, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_keywords_meta", "ru", 2, null, "contact_us_keywords_meta" },
                    { 455, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_title", "ru", 2, null, "faq_page_title" },
                    { 456, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_description_meta", "ru", 2, null, "faq_page_description_meta" },
                    { 457, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_header_title", "ru", 2, null, "faq_page_header_title" },
                    { 458, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_keywords_meta", "ru", 2, null, "faq_page_keywords_meta" },
                    { 459, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_title", "ru", 2, null, "products_page_title" },
                    { 460, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_category_title", "ru", 2, null, "products_filter_category_title" },
                    { 461, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_brands_title", "ru", 2, null, "products_filter_brands_title" },
                    { 462, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_price_range_title", "ru", 2, null, "products_filter_price_range_title" },
                    { 463, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_search_button", "ru", 2, null, "products_filter_search_button" },
                    { 464, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_title", "ru", 2, null, "products_sort_by_title" },
                    { 465, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_latest_items_option", "ru", 2, null, "products_sort_by_latest_items_option" },
                    { 466, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_best_seller_items_option", "ru", 2, null, "products_sort_by_best_seller_items_option" },
                    { 467, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_low_to_high_option", "ru", 2, null, "products_sort_by_price_low_to_high_option" },
                    { 468, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_high_to_low_option", "ru", 2, null, "products_sort_by_price_high_to_low_option" },
                    { 469, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_description_meta", "ru", 2, null, "products_page_description_meta" },
                    { 470, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_header_title", "ru", 2, null, "products_page_header_title" },
                    { 471, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_keywords_meta", "ru", 2, null, "products_page_keywords_meta" },
                    { 472, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_quantity_title", "ru", 2, null, "single_product_quantity_title" },
                    { 473, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_sku_title", "ru", 2, null, "single_product_sku_title" },
                    { 474, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_category_title", "ru", 2, null, "single_product_category_title" },
                    { 475, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_brand_title", "ru", 2, null, "single_product_brand_title" },
                    { 476, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_tags_title", "ru", 2, null, "single_product_tags_title" },
                    { 477, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_description_title", "ru", 2, null, "single_product_description_title" },
                    { 478, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_additional_info_title", "ru", 2, null, "single_product_additional_info_title" },
                    { 479, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_documents_title", "ru", 2, null, "single_product_documents_title" },
                    { 480, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_related_items_title", "ru", 2, null, "single_product_related_items_title" },
                    { 481, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_title", "ru", 2, null, "orders_page_title" },
                    { 482, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_title", "ru", 2, null, "orders_page_your_orders_title" },
                    { 483, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_title", "ru", 2, null, "orders_page_your_informations_title" },
                    { 484, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_image_th", "ru", 2, null, "orders_page_your_orders_image_th" },
                    { 485, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_name_th", "ru", 2, null, "orders_page_your_orders_name_th" },
                    { 486, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_price_th", "ru", 2, null, "orders_page_your_orders_price_th" },
                    { 487, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_quantity_th", "ru", 2, null, "orders_page_your_orders_quantity_th" },
                    { 488, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_subtotal_th", "ru", 2, null, "orders_page_your_orders_subtotal_th" },
                    { 489, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_category", "ru", 2, null, "orders_page_your_products_category" },
                    { 490, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_brand", "ru", 2, null, "orders_page_your_products_brand" },
                    { 491, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_title", "ru", 2, null, "orders_page_your_informations_first_name_title" },
                    { 492, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_placeholder", "ru", 2, null, "orders_page_your_informations_first_name_placeholder" },
                    { 493, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_title", "ru", 2, null, "orders_page_your_informations_last_name_title" },
                    { 494, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_placeholder", "ru", 2, null, "orders_page_your_informations_last_name_placeholder" },
                    { 495, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_title", "ru", 2, null, "orders_page_your_informations_email_title" },
                    { 496, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_placeholder", "ru", 2, null, "orders_page_your_informations_email_placeholder" },
                    { 497, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_title", "ru", 2, null, "orders_page_your_informations_phone_title" },
                    { 498, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_placeholder", "ru", 2, null, "orders_page_your_informations_phone_placeholder" },
                    { 499, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_title", "ru", 2, null, "orders_page_your_informations_address_title" },
                    { 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_placeholder", "ru", 2, null, "orders_page_your_informations_address_placeholder" },
                    { 501, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_description_title", "ru", 2, null, "orders_page_your_informations_description_title" },
                    { 502, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_title", "ru", 2, null, "orders_page_your_cart_summary_title" },
                    { 503, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_subtotal", "ru", 2, null, "orders_page_your_cart_summary_subtotal" },
                    { 504, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_discount", "ru", 2, null, "orders_page_your_cart_summary_discount" },
                    { 505, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_totalPrice", "ru", 2, null, "orders_page_your_cart_summary_totalPrice" },
                    { 506, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_checkout_now", "ru", 2, null, "orders_page_your_cart_summary_checkout_now" },
                    { 507, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_title", "ru", 2, null, "orders_page_your_cart_is_empty_title" },
                    { 508, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_subtitle", "ru", 2, null, "orders_page_your_cart_is_empty_subtitle" },
                    { 509, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_go_back_home_button", "ru", 2, null, "orders_page_your_cart_is_empty_go_back_home_button" },
                    { 510, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message_title", "ru", 2, null, "success_message_title" },
                    { 511, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message", "ru", 2, null, "success_message" },
                    { 512, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message_title", "ru", 2, null, "error_message_title" },
                    { 513, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message", "ru", 2, null, "error_message" },
                    { 514, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_in_cart_message", "ru", 2, null, "add_in_cart_message" },
                    { 515, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message_title", "ru", 2, null, "success_order_message_title" },
                    { 516, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message", "ru", 2, null, "success_order_message" },
                    { 517, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_to_cart", "tr", 2, null, "add_to_cart" },
                    { 518, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "loading_title", "tr", 2, null, "loading_title" },
                    { 519, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "view_more_button", "tr", 2, null, "view_more_button" },
                    { 520, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "follow_us_title", "tr", 2, null, "header_follow_us_title" },
                    { 521, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_title", "tr", 2, null, "header_whatsapp_title" },
                    { 522, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_whatsapp_sub_title", "tr", 2, null, "header_whatsapp_sub_title" },
                    { 523, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_my_cart_title", "tr", 2, null, "header_my_cart_title" },
                    { 524, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_is_empty", "tr", 2, null, "header_cart_is_empty" },
                    { 525, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_total", "tr", 2, null, "header_cart_total" },
                    { 526, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_checkout_button", "tr", 2, null, "header_cart_checkout_button" },
                    { 527, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_all_categories", "tr", 2, null, "header_all_categories" },
                    { 528, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_search_here", "tr", 2, null, "header_search_here" },
                    { 529, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_cart_search_here", "tr", 2, null, "header_cart_search_here" },
                    { 530, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "header_extra_pages", "tr", 2, null, "header_extra_pages" },
                    { 531, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_title", "tr", 3, null, "footer_title" },
                    { 532, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_copyright", "tr", 2, null, "footer_copyright" },
                    { 533, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_link_list", "tr", 2, null, "footer_link_list" },
                    { 534, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_category_list", "tr", 2, null, "footer_category_list" },
                    { 535, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "footer_extra_page_list", "tr", 2, null, "footer_extra_page_list" },
                    { 536, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "added_cart_title", "tr", 2, null, "added_cart_title" },
                    { 537, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_title", "tr", 2, null, "home_page_title" },
                    { 538, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_title", "tr", 2, null, "home_our_speciality_title" },
                    { 539, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_subtitle", "tr", 2, null, "home_our_speciality_subtitle" },
                    { 540, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_title", "tr", 2, null, "home_our_speciality_menu_title" },
                    { 541, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_speciality_menu_subtitle", "tr", 2, null, "home_our_speciality_menu_subtitle" },
                    { 542, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_latest_products_title", "tr", 2, null, "home_latest_products_title" },
                    { 543, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_title", "tr", 2, null, "home_our_blogs_title" },
                    { 544, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_our_blogs_subtitle", "tr", 2, null, "home_our_blogs_subtitle" },
                    { 545, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_description_meta", "tr", 2, null, "home_page_description_meta" },
                    { 546, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_header_title", "tr", 2, null, "home_page_header_title" },
                    { 547, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "home_page_keywords_meta", "tr", 2, null, "home_page_keywords_meta" },
                    { 548, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_page_title", "tr", 2, null, "menu_page_title" },
                    { 549, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "all_category_title", "tr", 2, null, "all_category_title" },
                    { 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_description_meta", "tr", 2, null, "menu_description_meta" },
                    { 551, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_header_title", "tr", 2, null, "menu_header_title" },
                    { 552, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "menu_keywords_meta", "tr", 2, null, "menu_keywords_meta" },
                    { 553, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_page_title", "tr", 2, null, "about_us_page_title" },
                    { 554, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_title", "tr", 2, null, "about_us_our_team_title" },
                    { 555, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_our_team_subtitle", "tr", 2, null, "about_us_our_team_subtitle" },
                    { 556, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_partners_title", "tr", 2, null, "about_us_partners_title" },
                    { 557, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_description_meta", "tr", 2, null, "about_us_description_meta" },
                    { 558, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_header_title", "tr", 2, null, "about_us_header_title" },
                    { 559, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "about_us_keywords_meta", "tr", 2, null, "about_us_keywords_meta" },
                    { 560, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_page_title", "tr", 2, null, "our_blogs_page_title" },
                    { 561, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_title", "tr", 2, null, "our_blogs_title" },
                    { 562, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_subtitle", "tr", 2, null, "our_blogs_subtitle" },
                    { 563, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_read_more_button", "tr", 2, null, "our_blogs_read_more_button" },
                    { 564, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_description_meta", "tr", 2, null, "our_blogs_description_meta" },
                    { 565, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_header_title", "tr", 2, null, "our_blogs_header_title" },
                    { 566, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "our_blogs_keywords_meta", "tr", 2, null, "our_blogs_keywords_meta" },
                    { 567, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_blog_tags", "tr", 2, null, "single_blog_tags" },
                    { 568, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_page_title", "tr", 2, null, "contact_us_page_title" },
                    { 569, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_address_title", "tr", 2, null, "contact_us_address_title" },
                    { 570, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_call_us_title", "tr", 2, null, "contact_us_call_us_title" },
                    { 571, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_email_us_title", "tr", 2, null, "contact_us_email_us_title" },
                    { 572, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_open_time_title", "tr", 2, null, "contact_us_open_time_title" },
                    { 573, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_title", "tr", 2, null, "contact_us_get_in_touch_title" },
                    { 574, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_subtitle", "tr", 2, null, "contact_us_get_in_touch_subtitle" },
                    { 575, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_button", "tr", 2, null, "contact_us_get_in_touch_button" },
                    { 576, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_name_placeholder", "tr", 2, null, "contact_us_get_in_touch_your_name_placeholder" },
                    { 577, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_email_placeholder", "tr", 2, null, "contact_us_get_in_touch_your_email_placeholder" },
                    { 578, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_phone_placeholder", "tr", 2, null, "contact_us_get_in_touch_your_phone_placeholder" },
                    { 579, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_subject_placeholder", "tr", 2, null, "contact_us_get_in_touch_your_subject_placeholder" },
                    { 580, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_get_in_touch_your_message_placeholder", "tr", 2, null, "contact_us_get_in_touch_your_message_placeholder" },
                    { 581, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_description_meta", "tr", 2, null, "contact_us_description_meta" },
                    { 582, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_header_title", "tr", 2, null, "contact_us_header_title" },
                    { 583, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "contact_us_keywords_meta", "tr", 2, null, "contact_us_keywords_meta" },
                    { 584, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_title", "tr", 2, null, "faq_page_title" },
                    { 585, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_description_meta", "tr", 2, null, "faq_page_description_meta" },
                    { 586, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_header_title", "tr", 2, null, "faq_page_header_title" },
                    { 587, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "faq_page_keywords_meta", "tr", 2, null, "faq_page_keywords_meta" },
                    { 588, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_title", "tr", 2, null, "products_page_title" },
                    { 589, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_category_title", "tr", 2, null, "products_filter_category_title" },
                    { 590, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_brands_title", "tr", 2, null, "products_filter_brands_title" },
                    { 591, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_price_range_title", "tr", 2, null, "products_filter_price_range_title" },
                    { 592, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_filter_search_button", "tr", 2, null, "products_filter_search_button" },
                    { 593, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_title", "tr", 2, null, "products_sort_by_title" },
                    { 594, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_latest_items_option", "tr", 2, null, "products_sort_by_latest_items_option" },
                    { 595, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_best_seller_items_option", "tr", 2, null, "products_sort_by_best_seller_items_option" },
                    { 596, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_low_to_high_option", "tr", 2, null, "products_sort_by_price_low_to_high_option" },
                    { 597, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_sort_by_price_high_to_low_option", "tr", 2, null, "products_sort_by_price_high_to_low_option" },
                    { 598, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_description_meta", "tr", 2, null, "products_page_description_meta" },
                    { 599, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_header_title", "tr", 2, null, "products_page_header_title" },
                    { 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "products_page_keywords_meta", "tr", 2, null, "products_page_keywords_meta" },
                    { 601, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_quantity_title", "tr", 2, null, "single_product_quantity_title" },
                    { 602, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_sku_title", "tr", 2, null, "single_product_sku_title" },
                    { 603, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_category_title", "tr", 2, null, "single_product_category_title" },
                    { 604, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_brand_title", "tr", 2, null, "single_product_brand_title" },
                    { 605, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_tags_title", "tr", 2, null, "single_product_tags_title" },
                    { 606, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_description_title", "tr", 2, null, "single_product_description_title" },
                    { 607, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_additional_info_title", "tr", 2, null, "single_product_additional_info_title" },
                    { 608, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_documents_title", "tr", 2, null, "single_product_documents_title" },
                    { 609, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "single_product_related_items_title", "tr", 2, null, "single_product_related_items_title" },
                    { 610, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_title", "tr", 2, null, "orders_page_title" },
                    { 611, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_title", "tr", 2, null, "orders_page_your_orders_title" },
                    { 612, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_title", "tr", 2, null, "orders_page_your_informations_title" },
                    { 613, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_image_th", "tr", 2, null, "orders_page_your_orders_image_th" },
                    { 614, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_name_th", "tr", 2, null, "orders_page_your_orders_name_th" },
                    { 615, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_price_th", "tr", 2, null, "orders_page_your_orders_price_th" },
                    { 616, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_quantity_th", "tr", 2, null, "orders_page_your_orders_quantity_th" },
                    { 617, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_orders_subtotal_th", "tr", 2, null, "orders_page_your_orders_subtotal_th" },
                    { 618, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_category", "tr", 2, null, "orders_page_your_products_category" },
                    { 619, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_products_brand", "tr", 2, null, "orders_page_your_products_brand" },
                    { 620, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_title", "tr", 2, null, "orders_page_your_informations_first_name_title" },
                    { 621, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_first_name_placeholder", "tr", 2, null, "orders_page_your_informations_first_name_placeholder" },
                    { 622, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_title", "tr", 2, null, "orders_page_your_informations_last_name_title" },
                    { 623, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_last_name_placeholder", "tr", 2, null, "orders_page_your_informations_last_name_placeholder" },
                    { 624, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_title", "tr", 2, null, "orders_page_your_informations_email_title" },
                    { 625, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_email_placeholder", "tr", 2, null, "orders_page_your_informations_email_placeholder" },
                    { 626, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_title", "tr", 2, null, "orders_page_your_informations_phone_title" },
                    { 627, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_phone_placeholder", "tr", 2, null, "orders_page_your_informations_phone_placeholder" },
                    { 628, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_title", "tr", 2, null, "orders_page_your_informations_address_title" },
                    { 629, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_address_placeholder", "tr", 2, null, "orders_page_your_informations_address_placeholder" },
                    { 630, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_informations_description_title", "tr", 2, null, "orders_page_your_informations_description_title" },
                    { 631, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_title", "tr", 2, null, "orders_page_your_cart_summary_title" },
                    { 632, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_subtotal", "tr", 2, null, "orders_page_your_cart_summary_subtotal" },
                    { 633, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_discount", "tr", 2, null, "orders_page_your_cart_summary_discount" },
                    { 634, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_totalPrice", "tr", 2, null, "orders_page_your_cart_summary_totalPrice" },
                    { 635, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_summary_checkout_now", "tr", 2, null, "orders_page_your_cart_summary_checkout_now" },
                    { 636, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_title", "tr", 2, null, "orders_page_your_cart_is_empty_title" },
                    { 637, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_subtitle", "tr", 2, null, "orders_page_your_cart_is_empty_subtitle" },
                    { 638, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orders_page_your_cart_is_empty_go_back_home_button", "tr", 2, null, "orders_page_your_cart_is_empty_go_back_home_button" },
                    { 639, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message_title", "tr", 2, null, "success_message_title" },
                    { 640, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_message", "tr", 2, null, "success_message" },
                    { 641, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message_title", "tr", 2, null, "error_message_title" },
                    { 642, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "error_message", "tr", 2, null, "error_message" },
                    { 643, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "add_in_cart_message", "tr", 2, null, "add_in_cart_message" },
                    { 644, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message_title", "tr", 2, null, "success_order_message_title" },
                    { 645, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "success_order_message", "tr", 2, null, "success_order_message" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactUsTranslations_ContactUsId_LanguageKey",
                table: "ContactUsTranslations",
                columns: new[] { "ContactUsId", "LanguageKey", "DeletedDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryTranslations_CategoryId_LanguageKey",
                table: "ProductCategoryTranslations",
                columns: new[] { "CategoryId", "LanguageKey", "DeletedDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTranslations_ProductId_LanguageKey",
                table: "ProductTranslations",
                columns: new[] { "ProductId", "LanguageKey", "DeletedDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_Key",
                table: "Settings",
                column: "Key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SliderImages_SliderId",
                table: "SliderImages",
                column: "SliderId");

            migrationBuilder.CreateIndex(
                name: "IX_SliderTranslations_SliderId_LanguageKey",
                table: "SliderTranslations",
                columns: new[] { "SliderId", "LanguageKey", "DeletedDate" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "ContactUsTranslations");

            migrationBuilder.DropTable(
                name: "CustomerMessages");

            migrationBuilder.DropTable(
                name: "ProductCategoryTranslations");

            migrationBuilder.DropTable(
                name: "ProductTranslations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "SliderImages");

            migrationBuilder.DropTable(
                name: "SliderTranslations");

            migrationBuilder.DropTable(
                name: "TextTranslations");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
