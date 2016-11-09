using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provider_DB
{
	public partial class MainForm : Form
	{
		PROVIDER_DBDataContext dc;

		public MainForm()
		{
			InitializeComponent();
			dc = new PROVIDER_DBDataContext();

			tabMainChanged();
		}

		//---------------------------------------------------------------------- tab changed ---------- >>

		private void tabMainChanged(object sender, EventArgs e)
		{
			tabMainChanged();
		}

		private void tabMainChanged()
		{
			switch (tabMain.SelectedIndex)
			{
				case 0:
					tabQueryChanged();
					break;
				case 1:
					tabTablesChanged();
					break;
			}
		}

		private void tabQueryChanged(object sender, EventArgs e)
		{
			tabQueryChanged();
		}

		private void tabQueryChanged()
		{
			comboBox_Query1.Items.Clear();
			comboBox_Query2.Items.Clear();
			comboBox_Query3.Items.Clear();
			comboBox_Query4.Items.Clear();
			comboBox_Query6.Items.Clear();
			switch (tabQuery.SelectedIndex)
			{
				case 0:
					var query1 = dc.co_workers;
					foreach (var item in query1)
					{
						comboBox_Query1.Items.Add(item.co_worker_name.ToString());
					}
					break;
				case 1:
					var query2 = dc.users;
					foreach (var item in query2)
					{
						comboBox_Query2.Items.Add(item.user_name.ToString());
					}
					break;
				case 2:
					var query3 = dc.users;
					foreach (var item in query3)
					{
						comboBox_Query3.Items.Add(item.user_name.ToString());
					}
					break;
				case 3:
					var query4 = dc.users;
					foreach (var item in query4)
					{
						comboBox_Query4.Items.Add(item.user_name.ToString());
					}
					break;
				case 5:
					var query6 = dc.rates;
					foreach (var item in query6)
					{
						comboBox_Query6.Items.Add(item.name_rate.ToString());
					}
					break;
			}
			if (comboBox_Query1.Items.Count > 0) comboBox_Query1.SelectedIndex = 0;
			if (comboBox_Query2.Items.Count > 0) comboBox_Query2.SelectedIndex = 0;
			if (comboBox_Query3.Items.Count > 0) comboBox_Query3.SelectedIndex = 0;
			if (comboBox_Query4.Items.Count > 0) comboBox_Query4.SelectedIndex = 0;
			if (comboBox_Query6.Items.Count > 0) comboBox_Query6.SelectedIndex = 0;
		}

		private void tabTablesChanged(object sender, EventArgs e)
		{
			tabTablesChanged();
		}

		private void tabTablesChanged()
		{
			switch (tabTables.SelectedIndex)
			{
				case 0:
					fillAgreements();
					break;
				case 1:
					fillUsers();
					break;
				case 2:
					fillTransactions();
					break;
				case 3:
					fillCo_workers();
					break;
				case 4:
					fillRates();
					break;
				case 5:
					fillCoverage_areas();
					break;
			}
		}

		//---------------------------------------------------------------------- tab changed ---------- <<

		//---------------------------------------------------------------------- fill tables ---------- >>

		private void fillAgreements()
		{
			// Перезаполним ComboBox-ы
			id_user.Items.Clear();
			id_coverage_area.Items.Clear();
			id_co_worker.Items.Clear();
			id_rate.Items.Clear();
			
			var query1 = dc.users;
			foreach (var item in query1) id_user.Items.Add(item.user_name.ToString());
			var query2 = dc.coverage_areas;
			foreach (var item in query2) id_coverage_area.Items.Add(item.coverage_area_id.ToString());
			var query3 = dc.co_workers;
			foreach (var item in query3) id_co_worker.Items.Add(item.co_worker_name.ToString());
			var query4 = dc.rates;
			foreach (var item in query4) id_rate.Items.Add(item.name_rate.ToString());

			if (id_user.Items.Count > 0)			id_user.SelectedIndex = 0;
			if (id_coverage_area.Items.Count > 0)	id_coverage_area.SelectedIndex = 0;
			if (id_co_worker.Items.Count > 0)		id_co_worker.SelectedIndex = 0;
			if (id_rate.Items.Count > 0)			id_rate.SelectedIndex = 0;

			// Перезаполним таблицу
			int countRow = agreements_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				agreements_list.Rows.RemoveAt(0);
			}
			var query5 = dc.agreements;
			int numRow = 0;
			foreach (var item in query5)
			{
				agreements_list.Rows.Add();
				agreements_list.Rows[numRow].Cells[0].Value = item.agreement_id.ToString();
				agreements_list.Rows[numRow].Cells[1].Value = item.users.user_name.ToString();
				agreements_list.Rows[numRow].Cells[2].Value = item.balance.ToString();
				agreements_list.Rows[numRow].Cells[3].Value = item.login.ToString();
				agreements_list.Rows[numRow].Cells[4].Value = item.password.ToString();
				agreements_list.Rows[numRow].Cells[5].Value = item.id_coverage_area.ToString();
				agreements_list.Rows[numRow].Cells[6].Value = item.num_apartment.ToString();
				agreements_list.Rows[numRow].Cells[7].Value = item.date_connection.ToString();
				agreements_list.Rows[numRow].Cells[8].Value = item.co_workers.co_worker_name.ToString() + " " +
																item.co_workers.co_worker_surname.ToString();
				agreements_list.Rows[numRow].Cells[9].Value = item.rates.name_rate.ToString();
				numRow++;
			}
		}

		private void fillUsers()
		{
			user_address.Text = "РайонУлица№дома << формат";
			user_address.ForeColor = Color.Gray;

			// Перезаполним таблицу
			int countRow = users_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				users_list.Rows.RemoveAt(0);
			}
			var query = dc.users;
			int numRow = 0;
			foreach (var item in query)
			{
				users_list.Rows.Add();
				users_list.Rows[numRow].Cells[0].Value = item.user_id.ToString();
				users_list.Rows[numRow].Cells[1].Value = item.user_surname.ToString();
				users_list.Rows[numRow].Cells[2].Value = item.user_name.ToString();
				users_list.Rows[numRow].Cells[3].Value = item.user_patronymic.ToString();
				users_list.Rows[numRow].Cells[4].Value = item.user_passport_data.ToString();
				users_list.Rows[numRow].Cells[5].Value = item.user_address.ToString();
				users_list.Rows[numRow].Cells[6].Value = item.user_contact_phone_num.ToString();
				numRow++;
			}
		}

		private void fillTransactions()
		{
			// Перезаполним ComboBox
			id_agreement.Items.Clear();
			var query1 = dc.agreements;
			foreach (var item in query1) id_agreement.Items.Add(item.agreement_id.ToString());
			if (id_agreement.Items.Count > 0) id_agreement.SelectedIndex = 0;

			// Перезаполним таблицу
			int countRow = transactions_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				transactions_list.Rows.RemoveAt(0);
			}
			var query2 = dc.transactions;
			int numRow = 0;
			foreach (var item in query2)
			{
				transactions_list.Rows.Add();
				transactions_list.Rows[numRow].Cells[0].Value = item.transaction_id.ToString();
				transactions_list.Rows[numRow].Cells[1].Value = item.id_agreement.ToString();
				transactions_list.Rows[numRow].Cells[2].Value = item.operation_type.ToString();
				transactions_list.Rows[numRow].Cells[3].Value = item.transaction_amount.ToString();
				transactions_list.Rows[numRow].Cells[4].Value = item.transaction_date.ToString();
				numRow++;
			}
		}

		private void fillCo_workers()
		{
			// Перезаполним таблицу
			int countRow = co_workers_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				co_workers_list.Rows.RemoveAt(0);
			}
			var query = dc.co_workers;
			int numRow = 0;
			foreach (var item in query)
			{
				co_workers_list.Rows.Add();
				co_workers_list.Rows[numRow].Cells[0].Value = item.co_worker_id.ToString();
				co_workers_list.Rows[numRow].Cells[1].Value = item.co_worker_surname.ToString();
				co_workers_list.Rows[numRow].Cells[2].Value = item.co_worker_name.ToString();
				co_workers_list.Rows[numRow].Cells[3].Value = item.co_worker_patronymic.ToString();
				co_workers_list.Rows[numRow].Cells[4].Value = item.co_worker_passport_data.ToString();
				co_workers_list.Rows[numRow].Cells[5].Value = item.co_worker_address.ToString();
				co_workers_list.Rows[numRow].Cells[6].Value = item.co_worker_contact_phone_num.ToString();
				co_workers_list.Rows[numRow].Cells[7].Value = item.post.ToString();
				co_workers_list.Rows[numRow].Cells[8].Value = item.salary.ToString();
				numRow++;
			}
		}

		private void fillRates()
		{
			// Перезаполним таблицу
			int countRow = rates_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				rates_list.Rows.RemoveAt(0);
			}
			var query = dc.rates;
			int numRow = 0;
			foreach (var item in query)
			{
				rates_list.Rows.Add();
				rates_list.Rows[numRow].Cells[0].Value = item.rate_id.ToString();
				rates_list.Rows[numRow].Cells[1].Value = item.name_rate.ToString();
				rates_list.Rows[numRow].Cells[2].Value = item.description.ToString();
				rates_list.Rows[numRow].Cells[3].Value = item.validity.ToString();
				rates_list.Rows[numRow].Cells[4].Value = item.cost.ToString();
				rates_list.Rows[numRow].Cells[5].Value = item.note.ToString();
				numRow++;
			}
		}

		private void fillCoverage_areas()
		{
			// Перезаполним таблицу
			int countRow = coverage_areas_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				coverage_areas_list.Rows.RemoveAt(0);
			}
			var query = dc.coverage_areas;
			int numRow = 0;
			foreach (var item in query)
			{
				coverage_areas_list.Rows.Add();
				coverage_areas_list.Rows[numRow].Cells[0].Value = item.coverage_area_id.ToString();
				coverage_areas_list.Rows[numRow].Cells[1].Value = item.district.ToString();
				coverage_areas_list.Rows[numRow].Cells[2].Value = item.street.ToString();
				coverage_areas_list.Rows[numRow].Cells[3].Value = item.num_house.ToString();
				numRow++;
			}
		}

		//---------------------------------------------------------------------- fill tables ---------- <<

		//------------------------------------------------------------------------- show item --------- >>

		private void showAgreement(object sender, EventArgs e)
		{
			/*if (agreements_list.RowCount <= 2  )
				return;

			int a1 = agreements_list.RowCount;
			int a2 = agreements_list.CurrentRow.Index;

			int countComboBoxItem = id_user.Items.Count;
			for (int i = 0; i < countComboBoxItem; i++)
			{
				if (id_user.Items[i].ToString() == agreements_list.Rows[agreements_list.CurrentRow.Index].Cells[1].Value.ToString())
					id_user.SelectedIndex = i;
			}*/
		}

		private void showUser(object sender, EventArgs e)
		{

		}

		private void showTransaction(object sender, EventArgs e)
		{

		}

		private void showCo_worker(object sender, EventArgs e)
		{

		}

		private void showRate(object sender, EventArgs e)
		{

		}

		private void showCoverage_area(object sender, EventArgs e)
		{

		}

		//------------------------------------------------------------------------- show item --------- <<

		//---------------------------------------------------------------------- buttons changed ------ >>

		private void btn_agreement_change_Click(object sender, EventArgs e)
		{
			/*if (agreements_list.Rows.Count == 0) return;

			if (!validationFieldsAgreement())
			{
				MessageBox.Show("Проверьте поля изменяемой записи !!!");
				return;
			}

			int cur_ag_id = Int32.Parse(agreements_list.Rows[agreements_list.CurrentRow.Index-1].Cells[0].Value.ToString());
			var agreement_upd = dc.agreements.Where(p => p.agreement_id == cur_ag_id).FirstOrDefault();
			if (agreement_upd != null)
			{
				//dc.agreements.
				//users new_user = (from u in dc.users
					//			  where u.user_id == Int32.Parse(id_user.SelectedIndex.ToString())
						//		  select u).Single<users>();
				//agreement_upd.id_user = ;
				//agreement_upd.balance = Int32.Parse(balance.Value.ToString());
				//agreement_upd.login = login.Text;
				//agreement_upd.password = password.Text;
				//agreement_upd.num_apartment = Int32.Parse(id_coverage_area.SelectedItem.ToString());
				//agreement_upd.date_connection = date_connection.Value;
				//agreement_upd.id_co_worker = dc.co_workers.FirstOrDefault(c => (c.co_worker_name + " " + c.co_worker_surname) ==
				//																id_co_worker.SelectedItem.ToString()).co_worker_id;
				//agreement_upd.id_rate = dc.rates.FirstOrDefault(c => c.name_rate == id_rate.SelectedItem.ToString()).rate_id;
				dc.agreements.Context.SubmitChanges();
			}
			*/
		}

		private void btn_user_change_Click(object sender, EventArgs e)
		{

		}

		private void btn_transaction_change_Click(object sender, EventArgs e)
		{

		}

		private void btn_co_worker_change_Click(object sender, EventArgs e)
		{

		}

		private void btn_rate_change_Click(object sender, EventArgs e)
		{

		}

		private void btn_coverage_area_change_Click(object sender, EventArgs e)
		{

		}

		//---------------------------------------------------------------------- buttons changed ------ <<
		
		//---------------------------------------------------------------------- buttons add ---------- >>

		private void btn_agreement_add_Click(object sender, EventArgs e)
		{
			var Agr = new agreements()
			{
				id_user = dc.users.FirstOrDefault(u => u.user_name == id_user.SelectedItem.ToString()).user_id,
				balance = Int32.Parse(balance.Value.ToString()),
				login = login.Text,
				password = password.Text,
				id_coverage_area = Int32.Parse(id_coverage_area.SelectedItem.ToString()),
				num_apartment = Int32.Parse(num_house.Value.ToString()),
				date_connection = Convert.ToDateTime(date_connection.Text),
				id_co_worker = dc.co_workers.FirstOrDefault(c => c.co_worker_name == id_co_worker.SelectedItem.ToString()).co_worker_id,
				id_rate = dc.rates.FirstOrDefault(r => r.name_rate == id_rate.SelectedItem.ToString()).rate_id
			};
			dc.agreements.InsertOnSubmit(Agr);
			dc.SubmitChanges();

			fillAgreements();
		}

		private void btn_user_add_Click(object sender, EventArgs e)
		{

		}

		private void btn_transaction_add_Click(object sender, EventArgs e)
		{

		}

		private void btn_co_worker_add_Click(object sender, EventArgs e)
		{

		}

		private void btn_rate_add_Click(object sender, EventArgs e)
		{

		}

		private void btn_coverage_area_add_Click(object sender, EventArgs e)
		{

		}

		//---------------------------------------------------------------------- buttons add ---------- <<

		//-------------------------------------------------------------------------- validation  ------ >>

		private bool validationFieldsAgreement()
		{
			if (id_user.SelectedItem.ToString() == "" || login.Text == "" ||
				password.Text == "" || id_coverage_area.SelectedItem.ToString() == "" ||
				id_co_worker.SelectedItem.ToString() == "" || id_rate.SelectedItem.ToString() == "")
				return false;
			return true;
		}

		private bool validationFieldsUser()
		{
			if (co_worker_surname.Text == "" || co_worker_name.Text == "" ||
				co_worker_patronymic.Text == "" || co_worker_passport_data.Text == "" ||
				co_worker_address.Text == "" || co_worker_contact_phone_num.Text == "")
				return false;
			return true;
		}

		private bool validationFieldsTransaction()
		{
			if (id_user.SelectedText == "Иван" || login.Text == "")
				return false;
			return true;
		}

		private bool validationFieldsCo_worker()
		{
			if (id_user.SelectedText == "Иван" || login.Text == "")
				return false;
			return true;
		}

		private bool validationFieldsRate()
		{
			if (id_user.SelectedText == "Иван" || login.Text == "")
				return false;
			return true;
		}

		private bool validationFieldsCoverage_area()
		{
			if (id_user.SelectedText == "Иван" || login.Text == "")
				return false;
			return true;
		}

		//-------------------------------------------------------------------------- validation  ------ <<

		
		// происходит когда элемент для ввода адреса пользователя стает активным
		private void user_address_Enter(object sender, EventArgs e)
		{
			if (user_address.Text == "РайонУлица№дома << формат")
			{
				user_address.Text = null;
				user_address.ForeColor = Color.Black;
			}
		}

		// происходит когда элемент для ввода адреса пользователя стает НЕактивным
		private void user_address_Leave(object sender, EventArgs e)
		{
			if (user_address.Text == "")
			{
				user_address.Text = "РайонУлица№дома << формат";
				user_address.ForeColor = Color.Gray;
			}
		}

		// обработчик кнопки выполнения запроса
		private void btn_query_exec_Click(object sender, EventArgs e)
		{
			ResultsList.Text = "";
			switch (tabQuery.SelectedIndex)
			{
				case 0:
					var query = from a in dc.agreements join c in dc.co_workers
								on a.id_co_worker equals c.co_worker_id
								where c.co_worker_name == (comboBox_Query1.SelectedItem.ToString())
					select a;
					string str = "";
					foreach (var item in query)
					{
						str += item.agreement_id.ToString() + " | " +
								item.users.user_name.ToString() + " | " +
								item.balance.ToString() + " | " +
								item.login.ToString() + " | " +
								item.password.ToString() + " | " +
								item.id_coverage_area.ToString() + " | " +
								item.num_apartment.ToString() + " | " +
								item.date_connection.ToString() + " | " +
								item.co_workers.co_worker_name.ToString() + " | " +
								item.rates.name_rate.ToString() + " | ";
						str += "\r\n";
					}
					ResultsList.Text = str;
					break;
				case 1:
					break;
			}
		}

		private void btn_result_clear_Click(object sender, EventArgs e)
		{
			ResultsList.Text = "";
		}

		

		

		
	}
}
