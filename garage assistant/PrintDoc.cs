using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garage_assistant
{

    internal class PrintDoc
    {
        public string 
            style= @"
<style>
		
html { overflow-x: hidden; }
@media screen {
body {
	width: 100%;
	height: 100%+5mm;
	margin: 0;
	margin-bottom: 10mm;
	padding: 5mm;			
	background-color: #CD5C5C;
	font-family: Algerian;
}            
.page {
width: 210mm;
height: 297mm;
padding: 10mm;
margin: 10mm auto;
border: 1px #D3D3D3 solid;
border-radius: 5px;
box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
background: white;
padding-top:0.5mm;
size: A4;
page-break-after: always;  	
}
}
@media print {
body {
	padding: 0;			
	} 
.page {
	width: 210mm;
	height: 297mm;
	padding: 10mm;
	margin: 0mm auto;
	background: white;
	padding-top:0.5mm;			
	size: A4;
	page-break-after: always;  	
	} 
} 
.description{
	padding:0mm;
	padding-top:0mm;
}
.org-name{
	width:65%;
	float:left;
}
.car-info-labels {
text-align:right;
width:9%; 
float:right;
margin-right:2mm;
font-size: 0.9rem;
}
.car-info{
	width:25%;
	float:right;
	font-size: 0.9rem;
}
.main-title{
	border: 3px solid black;
	text-align:  center;
	line-height: 2;
}
.fio{
margin-bottom:0mm;
}
.adress{
	line-height: 0.5;
}
.numb-phone-numb{
	margin:0;
	line-height: 0.5;
}
.phone{
	float: right;
}
.tables-body{
	margin:2mm;
	margin-top:20%;
	padding-top:0mm;
}
.sub-table-caption{
	margin:0;	
}
.sub-table-page-numb{
	float: right;
}
.empty-col{
	opacity: 0;
	border:none;
}
.total-sum-left{
	border: 3px solid black;
	border-right: 1px solid black; 
	text-align:left;		
}
.total-sum-right{
	border: 3px solid black;
	border-left: 1px solid black; 
	text-align:left;		
}
.total-sum{
	padding-top:0.35rem;
}
.total-sum-row{
	margin-top:1mm;
}
.page-footer{
	padding-top:15mm;
	margin:0mm;
}
.signatures{
	padding-top:5mm;
	font-size: 0.9rem;
}
.client-sign{
width:50%; 
float:left;
}
.worker-sign{
width:48%; 
float:right;
}
.table-col-numb{
	text-align:center;	
}
.table-col-name{
	padding-left:1rem;
	text-align:left;	
}
.table-col-numtype{
	text-align:center;	
}
.table-col-amount{
	text-align:center;	
}
.table-col-price{
	text-align:center;		
}
.table-col-summ{
	text-align:center;		
}
hr
{
	height: 0px;
	border: none;
	border-top: 3px solid black;
	padding: 0;
}
table
{
	width:100%;
	border-spacing: 0;
	
	font-size: 0.8rem;
}
table tr th {
  border: none;
  padding-top: 2mm;
}
td {         
	border: 1px solid black;
	white-space: nowrap;
	overflow: hidden;
	text-overflow: ellipsis;
	padding:0.5mm 0.5mm 0.5mm 0.5mm;         
}
td:nth-child(1) {
	min-width: 1.5rem;
	max-width: 1.5rem;
}
td:nth-child(2) {
	min-width: 28rem;
	max-width: 28rem;
}
td:nth-child(3) {
	min-width: 3rem;
	max-width:3rem;
}
td:nth-child(4) {
	min-width: 3rem;
	max-width:3rem;
}
td:nth-child(5) {
	min-width: 4.5rem;
	max-width:4.5rem;
}
td:nth-child(6) {
	min-width: 5.5rem;
	max-width:5.5rem;
}
		   </style>", 
			body= "";
		public List<string> tableW, tableD;

		public Docs Doc;
		public OrgInfo orgInfo= new OrgInfo
        {
			name= "Общество с ограниченной ответственносстью \"Тандем БЛАБЛА\"",
			adress = "г.Феодосия", phone="+7978XXXXXXX", numeral="123123123123" 
		};

        private StreamWriter streamwriter;
        public string path;
		public void AddRowWorks(int id, Work buf)
        {
			tableW.Add( $@"
						<tr>
						   <td>{id}</td>
						   <td>{buf.Name}</td>
						   <td>{buf.NumType}</td>
						   <td>{buf.Amount}</td>
						   <td>{buf.Price}</td>
						   <td>{buf.Summ}</td>
					   </tr>
						");
        }
		public void AddRowDetails(int id, Details buf) {
			tableD.Add($@"
						<tr>
						   <td>{id}</td>
						   <td>{buf.Name}</td>
						   <td>{buf.NumType}</td>
						   <td>{buf.Amount}</td>
						   <td>{buf.Price}</td>
						   <td>{buf.Summ}</td>
					   </tr>
						");
		}
		public string MakeTables(int page, string works, string details)
        {
			string res = $@"		
			<div class=tables-body>
			<p class=main-title><b> Заказ-наряд №{Doc.Id} от {Doc.date.ToShortDateString()}</b></p>			
				<div>
				<p class=sub-table-caption>
					<i>Работы</i> 
					<i class=sub-table-page-numb>Стр {page}</i>
				</p>
				<table>
					<thead>
						<tr>
						   <td class=table-col-numb><b>№</b></td>
						   <td class=table-col-name><b>Наименование</b></td>
						   <td class=table-col-numtype><b>Ед.изм.</b></td>
						   <td class=table-col-amount><b>Кол-во</b></td>
						   <td class=table-col-price><b>Цена</b></td>
						   <td class=table-col-summ><b>Сумма</b></td>
						</tr>
					</thead>
					<tbody>
						{works}
					</tbody>
					<tfoot >
						<tr>
							<td class=empty-col></td><td class=empty-col></td>
							<td  colspan=""3""><b>Итого работы</b></td>
							<td class=table-col-summ>{Doc.TotalWorks}</td>
						</tr>
					</tfoot>
				</table>
			</div>			
				<div>
				<p class=sub-table-caption>
					<i>Детали</i> 
					<i class=sub-table-page-numb>Стр {page}</i>
				</p>
				<table>
					<thead>
						<tr>
						   <td class=table-col-numb><b>№</b></td>
						   <td class=table-col-name><b>Наименование</b></td>
						   <td class=table-col-numtype><b>Ед.изм.</b></td>
						   <td class=table-col-amount><b>Кол-во</b></td>
						   <td class=table-col-price><b>Цена</b></td>
						   <td class=table-col-summ><b>Сумма</b></td>
						</tr>
					</thead>
					<tbody>
						{details}
					</tbody>
					<tfoot >
						<tr>
							<td class=empty-col></td><td class=empty-col></td>
							<td  colspan=""3""><b>Итого детали</b></td>
							<td class=table-col-summ>{Doc.TotalDetails}</td>
						</tr>
					</tfoot>
				</table>
			</div>
			<table class=total-sum>
					<tbody>
						<tr>
						   <td class=empty-col></td>
						   <td class=empty-col></td>
						   <td class=empty-col></td>
						   <td class=empty-col></td>
						   <td class=empty-col></td>
						   <td class=empty-col></td>
					   </tr>
						<tr class=total-sum-row>
							<td class=empty-col></td><td class=empty-col></td>
							<td class=total-sum-left colspan=""3""><b>Всего:</b></td>
							<td class=total-sum-right>{Doc.Total}</td>
						</tr>
					</tbody>
				</table>
				<p></p>
		</div>";
			return res;
		}
		public void AddPage(int page, string works, string details)
        {
			body += $@"
					<div class = page>
					<h2 class=fio>{Doc.Worker.FullName}</h2>
					<div>
						<p class=adress>{orgInfo.adress}</p>
					
						<p class=numb-phone-numb>
							<a>{orgInfo.numeral}</a>		
							<b class=phone> Тел.: {orgInfo.phone}</b>
						</p>

					</div>
					<hr style=""margin - bottom: 0; "">
					   <div class=description>
						<div class=org-name><p><b>{orgInfo.name}</b></p></div>
						<div class=car-info> 
							<p><b> {Doc.CrInfo.rc}&nbsp;</b></p>
							<p><b> {Doc.CrInfo.GovNumb}&nbsp;</b></p>
							<p> {Doc.CrInfo.VIN}&nbsp;</p>
							<p> {Doc.CrInfo.Mileage}&nbsp;</p>
						</div>
						<div class=car-info-labels> 
							<p><i>rc</i></p> 
							<p><i>Гос.номер</i></p>  
							<p><i>VIN</i></p> 
							<p><i>Пробег</i></p> 
						</div>
					</div>
					{this.MakeTables(page,works, details)}
					<div class=page-footer>
						<p>Автомобиль из ремонта получил <br>
						Претензий по качеству выполненных работ и замененных запчастей не имею</p>
						<div class=signatures>
							<div class=client-sign>Подпись клиента________________/________________/</div>
			
							<div class=worker-sign>Подпись исполнителя________________/{Doc.Worker.ShortName}</div>
						</div>
					</div>
				</div>
			";
        }
		public string MakeHTML()
        {
			string res = $@"
			<html>
			<head>
			<meta charset = ""utf - 8"" >
   
			   <title> Заказ наряд № {Doc.Id}</title>
			{style}
			</head >
			<body>{body}<body>
			<script>
			window.print();
			</script>
			</html>";
			body= String.Empty; 
			return res;
        }
		public PrintDoc()
        {
			tableW = new List<string>(){ };
			tableD=new List<string>(){ };
		}
        public void CompleteDoc(Docs Doc)
        {
			this.Doc = Doc;

			for (int i=0;i<= (tableW.Count + tableD.Count) / 20; i++)
            {
				string ws = "", ds = "";
				int wv = (tableW.Count - i * 10);
				int dv = (tableD.Count - i * 10);
				int wi = 20 - (dv < 10 ? dv : 10);
				int di = 20 - (wv < 10 ? wv : 10);
				for (int j = 0; ( j < wi )&&( j < wv ); j++)
                {
					ws += tableW[i * 10 + j];
                }
				for (int j = 0; (j < di)&&(j<dv); j++)
				{
					ds += tableD[i * 10 + j];
				}
				this.AddPage(i+1, ws, ds);

			}
			path = $@".\Заказ_наряд#{Doc.Id}.html";
			streamwriter = new StreamWriter(path);
			streamwriter.Write(this.MakeHTML());
			streamwriter.Close();
		}
    }
}
