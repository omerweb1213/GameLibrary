using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProducerGridView : System.Web.UI.Page
{
    WebService.WebService ws = new WebService.WebService();
    static WebService.Producers[] ProducersArr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ProducersArr = ws.GetAllProducers();
            for (int i = 0; i < 2; i++)
            {
                DropDownList1.Items.Add(ProducersGridView.Columns[i].HeaderText);
            }
            PopulateGrid(ProducersArr.OrderBy(x => x.ProducerID));
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void PopulateGrid(object obj)
    {
        ProducersGridView.DataSource = obj;
        ProducersGridView.DataBind();
    }
    protected void ProducersGridView_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (e.SortExpression == "ProducerID")
        {
            PopulateGrid(ProducersArr.OrderBy(x => x.ProducerID));
        }
        if (e.SortExpression == "ProducerName")
        {
            PopulateGrid(ProducersArr.OrderBy(x => x.ProducerName));
        }
    }
    protected void ProducersGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = ProducersGridView.Rows[e.RowIndex];
        int ProducerID = int.Parse(row.Cells[0].Text);
        ws.DeleteProducer(ProducerID);
        ProducersGridView.EditIndex = -1;
        ProducersArr = ws.GetAllProducers();
        PopulateGrid(ProducersArr.OrderBy(x => x.ProducerID));
    }
    protected void Search()
    {
        if (DropDownList1.SelectedValue == "ProducerID")
        {
            PopulateGrid(ProducersArr.Where(x => x.ProducerID.ToString().Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "ProducerName")
        {
            PopulateGrid(ProducersArr.Where(x => x.ProducerName.Contains(TextSearch.Text)));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Search();
    }
    protected void ProducersGridView_RowEditing(object sender, GridViewEditEventArgs e)
    {
        ProducersGridView.EditIndex = e.NewEditIndex;
        if (TextSearch.Text != "")
            Search();
        else
            PopulateGrid(ProducersArr.OrderBy(x => x.ProducerID));
    }
    protected void ProducersGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = ProducersGridView.Rows[e.RowIndex];
        WebService.Producers p1 = new WebService.Producers();
        p1.ProducerID = int.Parse(row.Cells[0].Text);
        p1.ProducerName = ((TextBox)(row.Cells[1].FindControl("TextBox1"))).Text;
        ws.UpdateProducers(p1.ProducerID, p1.ProducerName);
        ProducersGridView.EditIndex = -1;
        ProducersArr = ws.GetAllProducers();
        PopulateGrid(ProducersArr.OrderBy(x => x.ProducerID));
        
    }
    protected void ProducersGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        ProducersGridView.EditIndex = -1;
        PopulateGrid(ProducersArr.OrderBy(x => x.ProducerID));
    }

    protected void ProducersGridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((e.Row.RowType != DataControlRowType.Header) && (e.Row.RowType != DataControlRowType.Footer) && (e.Row.RowType != DataControlRowType.Pager))
        {
            Button DeleteButton = ((Button)(e.Row.Cells[3].FindControl("DeleteButton")));
            DeleteButton.Attributes["onclick"] = "javascript: return confirm('Are you sure you want to delete " + DataBinder.Eval(e.Row.DataItem, "ProducerName") + "?')";
        }
    }

}