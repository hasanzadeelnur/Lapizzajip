using Core.Persistence.Repositories;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class TextTranslationConfiguration : BaseEntityTypeConfiguration<TextTranslation, int>
{
    public override void Configure(EntityTypeBuilder<TextTranslation> builder)
    {
        builder.ToTable("TextTranslations").HasKey(c => c.Id);

        builder.Property(c => c.Key).HasColumnName("Key").HasMaxLength(100).IsRequired();
        builder.Property(c => c.Value).HasColumnName("Value").HasMaxLength(5000).IsRequired();
        builder.Property(c => c.Type).HasColumnName("Type").IsRequired();
        builder.Property(c => c.LanguageKey).HasColumnName("LanguageKey").HasMaxLength(2).IsRequired();

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);

        builder.HasData(GetSeeds());
    }

    private static IEnumerable<TextTranslation> GetSeeds()
    {
        List<TextTranslation> textTranslations = [];
        int id = 0;

        Dictionary<string, string> languages = [];
        languages.Add("ko", "Korean");
        languages.Add("en", "English");
        languages.Add("az", "Azerbaijan");
        languages.Add("ru", "Russian");
        languages.Add("tr", "Turkish");

        foreach (var language in languages) 
        {
            textTranslations.AddRange([
            new(++id,"add_to_cart","add_to_cart",language.Key,SettingType.Text),
            new(++id,"loading_title","loading_title",language.Key,SettingType.Text),
            new(++id,"view_more_button","view_more_button",language.Key,SettingType.Text),
            new(++id,"follow_us_title","header_follow_us_title",language.Key,SettingType.Text),
            new(++id,"header_whatsapp_title","header_whatsapp_title",language.Key,SettingType.Text),
            new(++id,"header_whatsapp_sub_title","header_whatsapp_sub_title",language.Key,SettingType.Text),
            new(++id,"header_my_cart_title","header_my_cart_title",language.Key,SettingType.Text),
            new(++id,"header_cart_is_empty","header_cart_is_empty",language.Key,SettingType.Text),
            new(++id,"header_cart_total","header_cart_total",language.Key,SettingType.Text),
            new(++id,"header_cart_checkout_button","header_cart_checkout_button",language.Key,SettingType.Text),
            new(++id,"header_all_categories","header_all_categories",language.Key,SettingType.Text),
            new(++id,"header_search_here","header_search_here",language.Key,SettingType.Text),
            new(++id,"header_cart_search_here","header_cart_search_here",language.Key,SettingType.Text),
            new(++id,"header_extra_pages","header_extra_pages",language.Key,SettingType.Text),

            new(++id,"footer_title","footer_title",language.Key,SettingType.Textbox),
            new(++id,"footer_copyright","footer_copyright",language.Key,SettingType.Text),
            new(++id,"footer_link_list","footer_link_list",language.Key,SettingType.Text),
            new(++id,"footer_category_list","footer_category_list",language.Key,SettingType.Text),
            new(++id,"footer_extra_page_list","footer_extra_page_list",language.Key,SettingType.Text),
            new(++id,"added_cart_title","added_cart_title",language.Key,SettingType.Text),

            new(++id,"home_page_title","home_page_title",language.Key,SettingType.Text),
            new(++id,"home_our_speciality_title","home_our_speciality_title",language.Key,SettingType.Text),
            new(++id,"home_our_speciality_subtitle","home_our_speciality_subtitle",language.Key,SettingType.Text),
            new(++id,"home_our_speciality_menu_title","home_our_speciality_menu_title",language.Key,SettingType.Text),
            new(++id,"home_our_speciality_menu_subtitle","home_our_speciality_menu_subtitle",language.Key,SettingType.Text),
            new(++id,"home_latest_products_title","home_latest_products_title",language.Key,SettingType.Text),
            new(++id,"home_our_blogs_title","home_our_blogs_title",language.Key,SettingType.Text),
            new(++id,"home_our_blogs_subtitle","home_our_blogs_subtitle",language.Key,SettingType.Text),
            new(++id,"home_page_description_meta","home_page_description_meta",language.Key,SettingType.Text),
            new(++id,"home_page_header_title","home_page_header_title",language.Key,SettingType.Text),
            new(++id,"home_page_keywords_meta","home_page_keywords_meta",language.Key,SettingType.Text),

            new(++id,"menu_page_title","menu_page_title",language.Key,SettingType.Text),
            new(++id,"all_category_title","all_category_title",language.Key,SettingType.Text),
            new(++id,"menu_description_meta","menu_description_meta",language.Key,SettingType.Text),
            new(++id,"menu_header_title","menu_header_title",language.Key,SettingType.Text),
            new(++id,"menu_keywords_meta","menu_keywords_meta",language.Key,SettingType.Text),

            new(++id,"about_us_page_title","about_us_page_title",language.Key,SettingType.Text),
            new(++id,"about_us_our_team_title","about_us_our_team_title",language.Key,SettingType.Text),
            new(++id,"about_us_our_team_subtitle","about_us_our_team_subtitle",language.Key,SettingType.Text),
            new(++id,"about_us_partners_title","about_us_partners_title",language.Key,SettingType.Text),
            new(++id,"about_us_description_meta","about_us_description_meta",language.Key,SettingType.Text),
            new(++id,"about_us_header_title","about_us_header_title",language.Key,SettingType.Text),
            new(++id,"about_us_keywords_meta","about_us_keywords_meta",language.Key,SettingType.Text),

            new(++id,"our_blogs_page_title","our_blogs_page_title",language.Key,SettingType.Text),
            new(++id,"our_blogs_title","our_blogs_title",language.Key,SettingType.Text),
            new(++id,"our_blogs_subtitle","our_blogs_subtitle",language.Key,SettingType.Text),
            new(++id,"our_blogs_read_more_button","our_blogs_read_more_button",language.Key,SettingType.Text),
            new(++id,"our_blogs_description_meta","our_blogs_description_meta",language.Key,SettingType.Text),
            new(++id,"our_blogs_header_title","our_blogs_header_title",language.Key,SettingType.Text),
            new(++id,"our_blogs_keywords_meta","our_blogs_keywords_meta",language.Key,SettingType.Text),

            new(++id,"single_blog_tags","single_blog_tags",language.Key,SettingType.Text),

            new(++id,"contact_us_page_title","contact_us_page_title",language.Key,SettingType.Text),
            new(++id,"contact_us_address_title","contact_us_address_title",language.Key,SettingType.Text),
            new(++id,"contact_us_call_us_title","contact_us_call_us_title",language.Key,SettingType.Text),
            new(++id,"contact_us_email_us_title","contact_us_email_us_title",language.Key,SettingType.Text),
            new(++id,"contact_us_open_time_title","contact_us_open_time_title",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_title","contact_us_get_in_touch_title",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_subtitle","contact_us_get_in_touch_subtitle",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_button","contact_us_get_in_touch_button",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_your_name_placeholder","contact_us_get_in_touch_your_name_placeholder",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_your_email_placeholder","contact_us_get_in_touch_your_email_placeholder",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_your_phone_placeholder","contact_us_get_in_touch_your_phone_placeholder",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_your_subject_placeholder","contact_us_get_in_touch_your_subject_placeholder",language.Key,SettingType.Text),
            new(++id,"contact_us_get_in_touch_your_message_placeholder","contact_us_get_in_touch_your_message_placeholder",language.Key,SettingType.Text),
            new(++id,"contact_us_description_meta","contact_us_description_meta",language.Key,SettingType.Text),
            new(++id,"contact_us_header_title","contact_us_header_title",language.Key,SettingType.Text),
            new(++id,"contact_us_keywords_meta","contact_us_keywords_meta",language.Key,SettingType.Text),

            new(++id,"faq_page_title","faq_page_title",language.Key,SettingType.Text),
            new(++id,"faq_page_description_meta","faq_page_description_meta",language.Key,SettingType.Text),
            new(++id,"faq_page_header_title","faq_page_header_title",language.Key,SettingType.Text),
            new(++id,"faq_page_keywords_meta","faq_page_keywords_meta",language.Key,SettingType.Text),

            new(++id,"products_page_title","products_page_title",language.Key,SettingType.Text),
            new(++id,"products_filter_category_title","products_filter_category_title",language.Key,SettingType.Text),
            new(++id,"products_filter_brands_title","products_filter_brands_title",language.Key,SettingType.Text),
            new(++id,"products_filter_price_range_title","products_filter_price_range_title",language.Key,SettingType.Text),
            new(++id,"products_filter_search_button","products_filter_search_button",language.Key,SettingType.Text),
            new(++id,"products_sort_by_title","products_sort_by_title",language.Key,SettingType.Text),
            new(++id,"products_sort_by_latest_items_option","products_sort_by_latest_items_option",language.Key,SettingType.Text),
            new(++id,"products_sort_by_best_seller_items_option","products_sort_by_best_seller_items_option",language.Key,SettingType.Text),
            new(++id,"products_sort_by_price_low_to_high_option","products_sort_by_price_low_to_high_option",language.Key,SettingType.Text),
            new(++id,"products_sort_by_price_high_to_low_option","products_sort_by_price_high_to_low_option",language.Key,SettingType.Text),
            new(++id,"products_page_description_meta","products_page_description_meta",language.Key,SettingType.Text),
            new(++id,"products_page_header_title","products_page_header_title",language.Key,SettingType.Text),
            new(++id,"products_page_keywords_meta","products_page_keywords_meta",language.Key,SettingType.Text),

            new(++id,"single_product_quantity_title","single_product_quantity_title",language.Key,SettingType.Text),
            new(++id,"single_product_sku_title","single_product_sku_title",language.Key,SettingType.Text),
            new(++id,"single_product_category_title","single_product_category_title",language.Key,SettingType.Text),
            new(++id,"single_product_brand_title","single_product_brand_title",language.Key,SettingType.Text),
            new(++id,"single_product_tags_title","single_product_tags_title",language.Key,SettingType.Text),
            new(++id,"single_product_description_title","single_product_description_title",language.Key,SettingType.Text),
            new(++id,"single_product_additional_info_title","single_product_additional_info_title",language.Key,SettingType.Text),
            new(++id,"single_product_documents_title","single_product_documents_title",language.Key,SettingType.Text),
            new(++id,"single_product_related_items_title","single_product_related_items_title",language.Key,SettingType.Text),

            new(++id,"orders_page_title","orders_page_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_orders_title","orders_page_your_orders_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_title","orders_page_your_informations_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_orders_image_th","orders_page_your_orders_image_th",language.Key,SettingType.Text),
            new(++id,"orders_page_your_orders_name_th","orders_page_your_orders_name_th",language.Key,SettingType.Text),
            new(++id,"orders_page_your_orders_price_th","orders_page_your_orders_price_th",language.Key,SettingType.Text),
            new(++id,"orders_page_your_orders_quantity_th","orders_page_your_orders_quantity_th",language.Key,SettingType.Text),
            new(++id,"orders_page_your_orders_subtotal_th","orders_page_your_orders_subtotal_th",language.Key,SettingType.Text),
            new(++id,"orders_page_your_products_category","orders_page_your_products_category",language.Key,SettingType.Text),
            new(++id,"orders_page_your_products_brand","orders_page_your_products_brand",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_first_name_title","orders_page_your_informations_first_name_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_first_name_placeholder","orders_page_your_informations_first_name_placeholder",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_last_name_title","orders_page_your_informations_last_name_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_last_name_placeholder","orders_page_your_informations_last_name_placeholder",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_email_title","orders_page_your_informations_email_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_email_placeholder","orders_page_your_informations_email_placeholder",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_phone_title","orders_page_your_informations_phone_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_phone_placeholder","orders_page_your_informations_phone_placeholder",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_address_title","orders_page_your_informations_address_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_address_placeholder","orders_page_your_informations_address_placeholder",language.Key,SettingType.Text),
            new(++id,"orders_page_your_informations_description_title","orders_page_your_informations_description_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_summary_title","orders_page_your_cart_summary_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_summary_subtotal","orders_page_your_cart_summary_subtotal",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_summary_discount","orders_page_your_cart_summary_discount",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_summary_totalPrice","orders_page_your_cart_summary_totalPrice",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_summary_checkout_now","orders_page_your_cart_summary_checkout_now",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_is_empty_title","orders_page_your_cart_is_empty_title",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_is_empty_subtitle","orders_page_your_cart_is_empty_subtitle",language.Key,SettingType.Text),
            new(++id,"orders_page_your_cart_is_empty_go_back_home_button","orders_page_your_cart_is_empty_go_back_home_button",language.Key,SettingType.Text),

            new(++id,"success_message_title","success_message_title",language.Key,SettingType.Text),
            new(++id,"success_message","success_message",language.Key,SettingType.Text),
            new(++id,"error_message_title","error_message_title",language.Key,SettingType.Text),
            new(++id,"error_message","error_message",language.Key,SettingType.Text),
            new(++id,"add_in_cart_message","add_in_cart_message",language.Key,SettingType.Text),
            new(++id,"success_order_message_title","success_order_message_title",language.Key,SettingType.Text),
            new(++id,"success_order_message","success_order_message",language.Key,SettingType.Text),
        ]);
        }

        return [.. textTranslations];
    }
}

