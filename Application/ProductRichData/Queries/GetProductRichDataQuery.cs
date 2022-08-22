using Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductRichData.Queries
{
    public record GetProductRichDataQuery : IRequest<ProductRichDataResponseDto>
    {
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }

    public class GetProductRichDataQueryHandler : IRequestHandler<GetProductRichDataQuery, ProductRichDataResponseDto>
    {
        public async Task<ProductRichDataResponseDto> Handle(GetProductRichDataQuery request, CancellationToken cancellationToken)
        {
            var response = new ProductRichDataResponseDto
            {
                Issuing_Agency = "GS1",
                Primary_DI_Number_GTIN = "3600040206577",
                Device_Count_Net_Content = 1,
                Company_Name = "company Name",
                Company_Physical_Address = "address",
                Brand_Name = "URISTIL® Supra-pubic drainage kit with silicone J tip catheter CH FR 08 and trocar CH FR 09",
                Version_or_Model = "version1",
                Catalog_Number = "CAT123456",
                Device_Description = "Supra-pubic drainage kit for bladder irrigation",
                DI_Record_Publish_Date = DateTime.Now,
                Commercial_Distribution_End_Date = DateTime.Now,
                Commercial_Distribution_Status = "status",
                Device_Subject_to_Direct_Marking_DMbut_Exempt = true,
                DM_DI_Different_from_Primary_DI = true,
                DM_DI_Number = "1",
                Secondary_DI_Number = "1",
                Previous_DI_Number = "1",
                Package_DI_Number = "1",
                Contains_DI_Package = "package",
                Quantity_per_Package = 200,
                Package_Type = "The complete set is placed in a high-density Polyethylene first pouch and then inserted in a Polypropylene/Polyethylene/Paper peel pouch.",
                Package_Discontinue_Date = DateTime.Now,
                Package_Status ="status",
                Human_Cell_Tissue_or_Cellular_or_Tissue_Based_Product_HCTP = true,
                Kit = true,
                Combination_Product = true,
                Device_Exempt_from_Premarket_Submission = true,
                FDA_Premarket_Submission_Number = "2",
                Supplement_Number = 1,
                Product_Code = "code",
                Product_Code_Name = "name",
                FDA_Listing_Number = "1232132",
                Code_SPL_GMDN_Preferred_Term_Code = 435432,
                SPL_Name_FDA_Preferred_Term_Code = "code",
                Name = "name",
                Definition = "definition",
                For_Single_Use = true,
                Lot_or_Batch_Number = true,
                Manufacturing_Date = true,
                Serial_Number = true,
                Expiration_Date = true,
                Donation_Identification_Number = true,
                Device_required_to_be_labeled_as_containing_natural_rubber_latex_or_dry_natural_rubber_21_CFR_801437 = true,
                Device_labeled_as_Not_made_with_natural_rubber_latex = true,
                Prescription_Use_Rx = true,
                Over_the_Counter_OTC = true,
                What_MRI_safety_information_does_the_labeling_contain = "label",
                Size_Type = "type",
                Size_Value = 22,
                Size_Unit_of_Measure = "unit",
                Size_Type_Text_SPL_Name_Size_Text = "text",
                Storage_and_Handling_Type = "avoid contact with water",
                High_Value_SPL_Name_Storage_and_Handling_High_Value = 50,
                Low_Value_SPL_Name_Storage_and_Handling_Low_Value = 10,
                Unit_of_Measure_SPL_Name_Storage_and_Handling_Unit_of_Measure = "Store away from light, in cool and dray place",
                Special_Storage_Conditions = "store in a closed container",
                Device_Packaged_as_Sterile = true,
                Requires_Sterilization_Prior_to_Use = true,
                Sterilization_Method = "method",
                Registration_number = "626/2021/1",
                Registration_date = DateTime.Now,
                Expiry_of_registeration_license = DateTime.Now,
                Variant = "var",
                Product_category_list = "Retrieving data. Wait a few seconds and try to cut or copy again.",
                Adopted_regulation = "Europen regulations ",
                Classification = "Iib",
                Composition = 'q',
                Dosage_form_or_non_dosage_form = true,
                Route_of_administration = "route",
                Code_of_federal_regulation_in_USA_only = true,
                Diagnostic_specificity = 'a',
                Diagnostic_sensitivity = 'b',
                The_price = 658,
                The_priced_pack =543,
                Unit_as_stated_in_the_invoice = 17,
                Currency = "Euro",
                Manufacturer_name = "manf name",
                Manufacturer_address = "manf address",
                Legal_manufacturer_name = "name",
                Legal_manufacturer_address = "address",
                Actual_manufacturer_name = "name",
                Actual_manufacturer_address = "address",
                Actual_manufacturer_Country_of_origin = "origin",
                OBL_name = "name",
                OBL_address = "address",
                OBL_Country_of_origin = "origin",
                OEM_name = "name",
                OEM_address = "address",
                OEM_Country_of_origin = "origin",
                Investment_License_No = 2,
                Is_contract_limited_On_Case_of_Toll = true,
                Company_Arabic_Name = "name",
                Tax_ID_Tax_registration_number =1,
                Product_type = "type",
                Postal_code = "code",
                Country = "Egypt",
                City = "cairo",
                Zone = "Nasr City",
                Website = "website",
                GLN_Number = "23467",
                Location_English_Name = "Location Name",
                Location_Arabic_Name = "اسم الموقع",
                Location_Country = "Egypt",
                Location_City = "cairo",
                Location_Contact_Email = "email",
                GPC_code = "Medical Device",
                GPC_name = "name",
                Country_of_Sale_Multi_Value_Target_Market = "Egypt",
                Product_Image = "image"
            };
            return response;
        }
    }
}
