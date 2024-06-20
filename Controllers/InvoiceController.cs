using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MockApi.Models;

[ApiController]
[Route("api/[controller]")]
public class InvoiceController : ControllerBase
{
    private readonly RequestStorage _requestStorage;

    public InvoiceController(RequestStorage requestStorage)
    {
        _requestStorage = requestStorage;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromQuery] string LoginToken, [FromBody] object request)
    {
        var requestData = $"LoginToken: {LoginToken}, RequestBody: {request.ToString()}";
        await _requestStorage.AddRequestAsync(requestData);

        var response = new InvoiceResponse
        {
            Invoice = new Invoice
            {
                CurrencyOverriddenFromScreen = false,
                INVID = 132470,
                INVInvoiceNumber = "IV88943",
                INVInvoiceDate = new DateTime(2024, 6, 20, 12, 0, 0),
                INVInvoiceDate_String = "20/06/24 12:00 PM",
                INVInvoiceDueDate = new DateTime(2024, 7, 20, 12, 0, 0),
                INVInvoiceDueDate_String = "20/07/24 12:00 PM",
                BillingCusID = 16165,
                BillingCusCode = "ACT1",
                BillingCusName = "Allclear Test 1",
                BillingCusEmail = "piq1customer@allclear.net.au",
                BillingCusPhone = null,
                BillingSiteID = 13929,
                IISID = 0,
                INVInvoiceReference = null,
                QQAKey = null,
                QQADKey = null,
                IsCreditNote = false,
                INVInternallyInvoiced = false,
                INVIsSalesInvoice = true,
                INVDateExported = null,
                INVDateExported_String = null,
                CurCode = null,
                CurRate = null,
                CurDate = null,
                CurForeignFixed = false,
                INVInvoiceSubTotal_ForeignAmount = null,
                INVInvoiceTotal_ForeignAmount = null,
                INVInvoiceGST_ForeignAmount = null,
                InvoiceDetails = new List<InvoiceDetail>
                {
                    new InvoiceDetail
                    {
                        LineNumber = 1,
                        IDTID = 286798,
                        IDTDescription = "Catering Label - Small",
                        IDTQuantity = 4.0000m,
                        IDTKinds = 1,
                        IGLACode = "4-6000",
                        IGLAName = "Sales - Warehouse",
                        IGLASuppressConsolidation = false,
                        IDTGSTName = "GST",
                        IDTGSTCode = "GST",
                        IDTGSTRate = 0.1000000m,
                        Quoted = 0.0000000000m,
                        Actual = 0.0000000000m,
                        IDTPrice_ForeignAmount = null,
                        IDTPriceAdjustment_ForeignAmount = null,
                        IIDTitle = "315406",
                        IMKey = 1,
                        ApplicationPath = "https://allclear.printiq.com/",
                        ChargeType = 1,
                        BasePrice = 0.0000000000m
                    },
                    new InvoiceDetail
                    {
                        LineNumber = 2,
                        IDTID = 286799,
                        IDTDescription = "Catering Label - Small",
                        IDTQuantity = 4.0000m,
                        IDTKinds = 1,
                        IGLACode = "4-6000",
                        IGLAName = "Sales - Warehouse",
                        IGLASuppressConsolidation = false,
                        IDTGSTName = "GST",
                        IDTGSTCode = "GST",
                        IDTGSTRate = 0.1000000m,
                        Quoted = 0.0000000000m,
                        Actual = 0.0000000000m,
                        IDTPrice_ForeignAmount = null,
                        IDTPriceAdjustment_ForeignAmount = null,
                        IIDTitle = "315406",
                        IMKey = 1,
                        ApplicationPath = "https://allclear.printiq.com/",
                        ChargeType = 1,
                        BasePrice = 0.0000000000m
                    },
                    new InvoiceDetail
                    {
                        LineNumber = 3,
                        IDTID = 286800,
                        IDTDescription = "Catering Label - Large",
                        IDTQuantity = 4.0000m,
                        IDTKinds = 1,
                        IGLACode = "4-6000",
                        IGLAName = "Sales - Warehouse",
                        IGLASuppressConsolidation = false,
                        IDTGSTName = "GST",
                        IDTGSTCode = "GST",
                        IDTGSTRate = 0.1000000m,
                        Quoted = 0.0000000000m,
                        Actual = 0.0000000000m,
                        IDTPrice_ForeignAmount = null,
                        IDTPriceAdjustment_ForeignAmount = null,
                        IIDTitle = "315406",
                        IMKey = 1,
                        ApplicationPath = "https://allclear.printiq.com/",
                        ChargeType = 1,
                        BasePrice = 0.0000000000m
                    },
                    new InvoiceDetail
                    {
                        LineNumber = 4,
                        IDTID = 286801,
                        IDTDescription = "Freight for Order 315406",
                        IDTQuantity = 1.0000m,
                        IDTKinds = 1,
                        IGLACode = "4-7000",
                        IGLAName = "Sales - Freight",
                        IGLASuppressConsolidation = false,
                        IDTGSTName = "GST",
                        IDTGSTCode = "GST",
                        IDTGSTRate = 0.1000000m,
                        Quoted = 0.0000000000m,
                        Actual = 19.8200000000m,
                        IDTPrice_ForeignAmount = null,
                        IDTPriceAdjustment_ForeignAmount = null,
                        IMKey = 1,
                        ApplicationPath = "https://allclear.printiq.com/",
                        ChargeType = 1,
                        BasePrice = 19.8200000000m
                    },
                    new InvoiceDetail
                    {
                        LineNumber = 5,
                        IDTID = 286802,
                        IDTDescription = "Pick and Pack for 315406",
                        IDTQuantity = 1.0000m,
                        IDTKinds = 1,
                        IGLACode = "4-6000",
                        IGLAName = "Sales - Warehouse",
                        IGLASuppressConsolidation = false,
                        IDTGSTName = "GST",
                        IDTGSTCode = "GST",
                        IDTGSTRate = 0.1000000m,
                        Quoted = 0.0000000000m,
                        Actual = 16.5000000000m,
                        IDTPrice_ForeignAmount = null,
                        IDTPriceAdjustment_ForeignAmount = null,
                        IMKey = 1,
                        ApplicationPath = "https://allclear.printiq.com/",
                        ChargeType = 1,
                        BasePrice = 16.5000000000m
                    }
                },
                InvoiceSummaryDetails = new List<InvoiceSummaryDetail>
                {
                    new InvoiceSummaryDetail
                    {
                        LineNumber = 1,
                        Description = "Catering Label - Small",
                        Quantity = 4.0000m,
                        Price_ExTax = 0.0000000000m,
                        Price_Tax = 0.0000000000m,
                        Price_IncTax = 0.0000000000m,
                        JobTitle = "315406"
                    },
                    new InvoiceSummaryDetail
                    {
                        LineNumber = 7,
                        Description = "Catering Label - Small",
                        Quantity = 4.0000m,
                        Price_ExTax = 0.0000000000m,
                        Price_Tax = 0.0000000000m,
                        Price_IncTax = 0.0000000000m,
                        JobTitle = "315406"
                    },
                    new InvoiceSummaryDetail
                    {
                        LineNumber = 7,
                        Description = "Catering Label - Large",
                        Quantity = 4.0000m,
                        Price_ExTax = 0.0000000000m,
                        Price_Tax = 0.0000000000m,
                        Price_IncTax = 0.0000000000m,
                        JobTitle = "315406"
                    },
                    new InvoiceSummaryDetail
                    {
                        LineNumber = 7,
                        Description = "Freight for Order 315406",
                        Quantity = 1.0000m,
                        Price_ExTax = 19.8200000000m,
                        Price_Tax = 1.9800000000m,
                        Price_IncTax = 21.8000000000m
                    },
                    new InvoiceSummaryDetail
                    {
                        LineNumber = 7,
                        Description = "Pick and Pack for 315406",
                        Quantity = 1.0000m,
                        Price_ExTax = 16.5000000000m,
                        Price_Tax = 1.6500000000m,
                        Price_IncTax = 18.1500000000m
                    }
                },
                INVInvoiceTotal = 39.9500000000m,
                INVAmountPaid = 0.0m,
                INVInvoiceGST = 3.6300000000m,
                INVInvoiceSubTotal = 36.3200000000m,
                INVIsCreditTopUp = false,
                HistoryDescription = "Invoice was created as Draft",
                INVCanExport = false,
                INVIsReadOnly = false,
                INVHasSupplierLines = false,
                CanConsolidate = true,
                TaxIntegrationError = null
            },
            ErrorMessage = null,
            IsError = false,
            WarningMessage = null,
            IsWarning = false
        };

        // Return the response as JSON
        return Ok(response);
    }
}
