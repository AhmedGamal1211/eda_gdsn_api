using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ProductRichDataResponseDto
    {
        [MaxLength(3)]
        public string? Issuing_Agency { get; set; }
        [MaxLength(14)]
        public string Primary_DI_Number_GTIN { get; set; }
        public int Device_Count_Net_Content { get; set; }
        [MaxLength(500)]
        public string Company_Name { get; set; }
        [MaxLength(2500)]
        public string Company_Physical_Address { get; set; }
        [MaxLength(80)]
        public string Brand_Name { get; set; }
        [MaxLength(40)]
        public string? Version_or_Model { get; set; }
        [MaxLength(40)]
        public string? Catalog_Number { get; set; }
        [MaxLength(2000)]
        public string Device_Description { get; set; }
        public DateTime? DI_Record_Publish_Date{ get; set; }
        public DateTime? Commercial_Distribution_End_Date { get; set; }
        [MaxLength(30)]
        public string? Commercial_Distribution_Status { get; set; }
        public bool? Device_Subject_to_Direct_Marking_DMbut_Exempt { get; set; }
        public bool? DM_DI_Different_from_Primary_DI { get; set; }
        [MaxLength(24)]
        public string? DM_DI_Number { get; set; }
        [MaxLength(24)]
        public string? Secondary_DI_Number { get; set; }
        [MaxLength(40)]
        public string? Previous_DI_Number { get; set; }
        [MaxLength(40)]
        public string? Package_DI_Number { get; set; }
        [MaxLength(250)]
        public string? Contains_DI_Package { get; set; }
        public int Quantity_per_Package { get; set; }
        [MaxLength(20)]
        public string Package_Type { get; set; }
        public DateTime? Package_Discontinue_Date { get; set; }
        [MaxLength(30)]
        public string? Package_Status { get; set; }
        public bool? Human_Cell_Tissue_or_Cellular_or_Tissue_Based_Product_HCTP { get; set; }
        public bool? Kit { get; set; }
        public bool? Combination_Product { get; set; }
        public bool? Device_Exempt_from_Premarket_Submission { get; set; }
        [MaxLength(8)]
        public string? FDA_Premarket_Submission_Number { get; set; }
        public int? Supplement_Number { get; set; }
        [MaxLength(3)]
        public string? Product_Code { get; set; }
        [MaxLength(3)]
        public string? Product_Code_Name { get; set; }
        [MaxLength(7)]
        public string? FDA_Listing_Number { get; set; }
        public int? Code_SPL_GMDN_Preferred_Term_Code { get; set; }
        [MaxLength(5)]
        public string? SPL_Name_FDA_Preferred_Term_Code { get; set; }
        [MaxLength(300)]
        public string? Name { get; set; }
        [MaxLength(2000)]
        public string? Definition { get; set; }
        public bool For_Single_Use { get; set; }
        public bool? Lot_or_Batch_Number { get; set; }
        public bool? Manufacturing_Date { get; set; }
        public bool? Serial_Number { get; set; }
        public bool? Expiration_Date { get; set; }
        public bool? Donation_Identification_Number { get; set; }
        public bool? Device_required_to_be_labeled_as_containing_natural_rubber_latex_or_dry_natural_rubber_21_CFR_801437 { get; set; }
        public bool? Device_labeled_as_Not_made_with_natural_rubber_latex { get; set; }
        public bool? Prescription_Use_Rx { get; set; }
        public bool? Over_the_Counter_OTC { get; set; }
        [MaxLength(50)]
        public string? What_MRI_safety_information_does_the_labeling_contain { get; set; }
        [MaxLength(50)]
        public string? Size_Type { get; set; }
        public decimal? Size_Value { get; set; }
        [MaxLength(80)]
        public string? Size_Unit_of_Measure { get; set; }
        [MaxLength(200)]
        public string? Size_Type_Text_SPL_Name_Size_Text { get; set; }
        [MaxLength(80)]
        public string? Storage_and_Handling_Type { get; set; }
        public int? High_Value_SPL_Name_Storage_and_Handling_High_Value { get; set; }
        public int? Low_Value_SPL_Name_Storage_and_Handling_Low_Value { get; set; }
        [MaxLength(50)]
        public string Unit_of_Measure_SPL_Name_Storage_and_Handling_Unit_of_Measure { get; set; }
        [MaxLength(250)]
        public string? Special_Storage_Conditions { get; set; }
        public bool? Device_Packaged_as_Sterile { get; set; }
        public bool? Requires_Sterilization_Prior_to_Use { get; set; }
        [MaxLength(60)]
        public string? Sterilization_Method { get; set; }
        [MaxLength(40)]
        public string? Registration_number { get; set; }
        public DateTime? Registration_date { get; set; }
        public DateTime? Expiry_of_registeration_license { get; set; }
        [MaxLength(80)]
        public string? Variant { get; set; }
        [MaxLength(120)]
        public string Product_category_list { get; set; }
        [MaxLength(20)]
        public string Adopted_regulation { get; set; }
        [MaxLength(40)]
        public string Classification { get; set; }
        public char? Composition { get; set; }
        public bool? Dosage_form_or_non_dosage_form { get; set; }
        [MaxLength(20)]
        public string? Route_of_administration { get; set; }
        public bool? Code_of_federal_regulation_in_USA_only  { get; set; }
        public char? Diagnostic_specificity { get; set; }
        public char? Diagnostic_sensitivity { get; set; }
        public decimal? The_price { get; set; }
        public decimal? The_priced_pack { get; set; }
        public decimal Unit_as_stated_in_the_invoice { get; set; }
        [MaxLength(5)]
        public string Currency { get; set; }
        [MaxLength(500)]
        public string? Manufacturer_name { get; set; }
        [MaxLength(2500)]
        public string? Manufacturer_address { get; set; }
        [MaxLength(500)]
        public string? Legal_manufacturer_name { get; set; }
        [MaxLength(2500)]
        public string? Legal_manufacturer_address { get; set; }
        [MaxLength(500)]
        public string? Actual_manufacturer_name { get; set; }
        [MaxLength(2500)]
        public string? Actual_manufacturer_address { get; set; }
        [MaxLength(3500)]
        public string? Actual_manufacturer_Country_of_origin { get; set; }
        [MaxLength(500)]
        public string? OBL_name { get; set; }
        [MaxLength(2500)]
        public string? OBL_address { get; set; }
        [MaxLength(120)]
        public string? OBL_Country_of_origin { get; set; }
        [MaxLength(500)]
        public string? OEM_name { get; set; }
        [MaxLength(2500)]
        public string? OEM_address { get; set; }
        [MaxLength(120)]
        public string? OEM_Country_of_origin { get; set; }
        public int? Investment_License_No { get; set; }
        public bool? Is_contract_limited_On_Case_of_Toll { get; set; }
        [MaxLength(500)]
        public string? Company_Arabic_Name { get; set; }
        public int? Tax_ID_Tax_registration_number { get; set; }
        [MaxLength(2500)]
        public string Product_type { get; set; }
        [MaxLength(50)]
        public string Postal_code{ get; set; }
        [MaxLength(120)]
        public string Country { get; set; }
        [MaxLength(120)]
        public string City { get; set; }
        [MaxLength(120)]
        public string Zone { get; set; }
        [MaxLength(250)]
        public string Website { get; set; }
        [MaxLength(13)]
        public string? GLN_Number { get; set; }
        [MaxLength(2500)]
        public string Location_English_Name { get; set; }
        [MaxLength(2500)]
        public string? Location_Arabic_Name { get; set; }
        [MaxLength(120)]
        public string Location_Country { get; set; }
        [MaxLength(120)]
        public string Location_City { get; set; }
        [MaxLength(300)]
        public string Location_Contact_Email { get; set; }
        [MaxLength(8)]
        public string GPC_code { get; set; }
        [MaxLength(250)]
        public string GPC_name { get; set; }
        [MaxLength(3500)]
        public string? Country_of_Sale_Multi_Value_Target_Market { get; set; }
        [MaxLength(3000)]
        public string? Product_Image { get; set; }

    }
}
