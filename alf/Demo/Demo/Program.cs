using System;

namespace Demo
{
	class MainClass
	{
		public static int[] Card_distribution()
		{
			Random rand = new Random();
			int[] id_card = new int[8];
			int[] repeat = new int[8];
			int[] player_cards = new int[8];
			int copy, i = 0, z = 0;
			bool test = false;
			for (int j = 0; j < 8; j++)
				id_card[j] = j;
			do
			{
				test = false;
				copy = rand.Next(0, 8);
				for (int j = 0; j < 8; j++)
					if (repeat[j] == copy)
						test = true;
				if (test == false)
				{
					repeat[z] = copy;
					z++;
					player_cards[i] = copy;
					i++;
				}
			} while (i < 7);
			return player_cards;
		}

		public static void Training()
		{
			Random r = new Random();
			int hand_bot, hand_player;
			byte p, pow_player = 0, pow_bot = 0;
			string out_player = " ", out_bot = " ";
			int[] comp = new int[2];
			byte[] hand = new byte[2];
			Console.Clear();
			Console.WriteLine("У вас есть на руках 4 части:" +
			                  "\n 1.Часть Жизни" +
			                  "\n 2.Часть Воды" +
			                  "\n 3.Часть Земли" +
			                  "\n 4.Часть Света");
			Console.WriteLine("\nСоставте карту.\nДля этого соедините Часть Воды с Частью Земли");
			Console.Write(" Выберите Часть Воды > ");
			p = Convert.ToByte(Console.ReadLine());
			if (p != 2)
			{
				Training();
			}
			Console.Write(" Выберите Часть Земли > ");
			p = Convert.ToByte(Console.ReadLine());
			if (p != 3)
				while(p != 3)
			{
					Console.Clear();
				Console.Write("У вас есть на руках 4 части:" +
				              "\n 1.Часть Жизни" +
				              "\n 2.Часть Воды" +
				              "\n 3.Часть Земли" +
				              "\n 4.Часть Света" +
				              "\n\nСоставте карту.\nДля этого соедините Часть Воды с Частью Земли" +
				              "\n Выберите Часть Воды > 2" +
				              "\n Выберите Часть Земли > ");
					p = Convert.ToByte(Console.ReadLine());
			}
			Console.Clear();
			Console.Write("Теперь у Вас в руке есть Карта Синий гигант!" +
			              "\nВаш опонент соединил часть Жизни с частью Огня!" +
			              "\nУ него в руке Карта Огненный элементаль!\n\nНажмите Enter для продолжения..");
			Console.Clear();
			Console.WriteLine("\tCиний гигант\tX\tОгенный элементаль");
			Console.Write(" \nПобеждает Карта Синий гигант\n\n Вы одержали победу!\n\n Для продолжения в меню нажмите Enter..");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("У Вас в руке 4 части:" +
							  "\n 1.Часть Земли" +
							  "\n 2.Часть Воды" +
							  "\n 3.Часть Жизни" +
							  "\n 4.Часть Света" +
							  "\nВаша первая Часть Земли");
			comp[0] = 1;
			Console.Write("Выберите вторую часть > ");
			comp[1] = Convert.ToInt16(Console.ReadLine());
			if (comp[0] == comp[1])
				do
				{
					Console.Clear(); Console.Write("У Вас в руке 4 части:" +
							  "\n 1.Часть Земли" +
							  "\n 2.Часть Воды" +
							  "\n 3.Часть Жизни" +
							  "\n 4.Часть Света" +
							  "\nВаша первая Часть Земли" +
				              "\nВыберите вторую часть > ");

				comp[1] = Convert.ToInt16(Console.ReadLine());
				} while (comp[0] == comp[1]);
			if (comp[1] == 2) { hand_player = 1; Console.Write("Вы соединили Часть Земли и Часть Воды\nУ Вас в руке Карта Синий гигант"); pow_player = 7; out_player = "Карта Синий гигант"; }
			else if (comp[1] == 3) { hand_player = 2; Console.Write("Вы соединили Часть Земли и Часть Жизни\nУ Вас в руке Карта Голиаф"); pow_player = 2; out_player = "Карта Голиаф"; }
			else if (comp[1] == 4) { hand_player = 3; Console.Write("Вы соединили Часть Земли и Часть Света\nУ Вас в руке Карта Нирвана"); pow_player = 6; out_player = "Карта Нирвана"; }
			comp[0] = r.Next(1, 5);
			do
			{
				comp[1] = r.Next(1, 5);
			} while (comp[0] == comp[1]);
			if (comp[0] == 1 && comp[1] == 2) { hand_bot = 1; Console.Write("\nПротивник соединили Часть Земли и Часть Воды\nУ него в руке Карта Синий гигант"); pow_bot = 7; out_bot = "Карта Синий гигант"; }
			else if (comp[0] == 1 && comp[1] == 3) { hand_bot = 2; Console.Write("\nПротивник соединили Часть Земли и Часть Жизни\nУ него в руке Карта Голиаф"); pow_bot = 2; out_bot = "Карта Голиаф"; }
			else if (comp[0] == 1 && comp[1] == 4) { hand_bot = 3; Console.Write("\nПротивник соединили Часть Земли и Часть Света\nУ него в руке Карта Нирвана"); pow_bot = 6; out_bot = "Карта"; }
			else if (comp[0] == 2 && comp[1] == 1) { hand_bot = 4; Console.Write("\nПротивник соединили Часть Воды и Часть Земли\nУ него в руке Карта Синий гигант"); pow_bot = 7; out_bot = "Карта Синий гигант"; }
			else if (comp[0] == 2 && comp[1] == 3) { hand_bot = 5; Console.Write("\nПротивник соединили Часть Воды и Часть Жизни\nУ него в руке Карта Карта Водный элементаль"); pow_bot = 4; out_bot = "Карта Водный элементаль"; }
			else if (comp[0] == 2 && comp[1] == 4) { hand_bot = 6; Console.Write("\nПротивник соединили Часть Воды и Часть Светва\nУ него в руке Карта Сияние"); pow_bot = 3; out_bot = "Карта Сияние"; }
			else if (comp[0] == 3 && comp[1] == 1) { hand_bot = 7; Console.Write("\nПротивник соединили Часть Жизни и Часть Земли\nУ него в руке Карта Голиаф"); pow_bot = 2; out_bot = "Карта Голиаф"; }
			else if (comp[0] == 3 && comp[1] == 2) { hand_bot = 8; Console.Write("\nПротивник соединили Часть Жизни и Часть Воды\nУ него в руке Карта Водный элементаль"); pow_bot = 4; out_bot = "Карта Водный элементаль"; }
			else if (comp[0] == 3 && comp[1] == 4) { hand_bot = 9; Console.Write("\nПротивник соединили Часть Жизни и Часть Света\nУ него в руке Карта Люцефер"); pow_bot = 1; out_bot = "Карта Люцефер"; }
			else if (comp[0] == 4 && comp[1] == 1) { hand_bot = 10; Console.Write("\nПротивник соединили Часть Света и Часть Земли\nУ него в руке Карта Нирвана "); pow_bot = 6; out_bot = "Карта Нирвана"; }
			else if (comp[0] == 4 && comp[1] == 2) { hand_bot = 11; Console.Write("\nПротивник соединили Часть Света и Воды Часть Воды\nУ него в руке Карта Сияние "); pow_bot = 3; out_bot = "Карта Сияние"; }
			else if (comp[0] == 4 && comp[1] == 3) { hand_bot = 12; Console.Write("\nПротивник соединили Часть Света и Часть Жизни\nУ него в руке Карта Люцефер"); pow_bot = 1; out_bot = "Карта Люцефер"; }
			Console.Write("\nНажмите Enter для прололжения..");
			Console.ReadKey();
			Console.Clear();
			Console.WriteLine("\t" + out_player + "\tX\t" + out_bot);
			if (pow_player > pow_bot) Console.Write("Вы победили!");
			else if (pow_player < pow_bot) Console.Write("Вы проиграли!");
			else if (pow_player == pow_bot) Console.Write("Ничья!");
			Console.ReadKey();
			Menu();
		}

		public static void List_of_cards()
		{
			byte ind;
			Console.Clear();
			Console.Write("1.Для части Воды" +
			                  "\n2.Для части Воздуха" +
			                  "\n3.Для части Жизни" +
			                  "\n4.Для части Земли" +
			                  "\n5.Для части Огня" +
			                  "\n6.Для части Света" +
			                  "\n7.Для части Смерти" +
			                  "\n8.Для части Тьмы" +
			                  "\n\n0.Назад к правилам" +
			                  "\n > ");
			ind = Convert.ToByte(Console.ReadLine());
			switch (ind)
			{
				case 1:
					Console.Clear(); Console.WriteLine("Часть Воды:" +
									  "\n + Часть Воздуха = Карта Тайфун" +
									  "\n + Часть Жизни = Карта Водяной элементаль" +
									  "\n + Часть Земли = Карта Синий гигант" +
									  "\n + Часть Огня = Карта Мгла" +
									  "\n + Часть Света = Карта Сияние" +
									  "\n + Часть Смерти = Карта Согра" +
									  "\n + Часть Тьмы = Карта Левиафан"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 2:
					Console.Clear(); Console.WriteLine("Часть Воздуха:" +
									  "\n + Часть Воды = Карта Тайфун" +
									  "\n + Часть Жизни = Карта Воздушный элементаль" +
									  "\n + Часть Земли = Карта Песчаная Буря" +
									  "\n + Часть Огня = Карта Пламенный Шквал" +
									  "\n + Часть Света = Карта Меркурий" +
									  "\n + Часть Смерти = Карта Смерч" +
									  "\n + Часть Тьмы = Карта Мерезин"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 3:
					Console.Clear(); Console.WriteLine(" Часть Жизни:" +
									  "\n + Часть Воды = Карта Водный элементаль" +
									  "\n + Часть Воздуха = Карта Воздушный элементаль" +
									  "\n + Часть Земли = Карта Голем" +
									  "\n + Часть Огня = Карта Огненный элементаль" +
									  "\n + Часть Света = Карта Люцефер" +
									  "\n + Часть Смерти = Карта Агония" +
									  "\n + Часть Тьмы = Карта Дарккид"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 4:
					Console.Clear(); Console.WriteLine(" Часть Земли:" +
									  "\n + Часть Воды = Карта Синий гигант" +
									  "\n + Часть Воздуха = Карта Песчаная буря" +
									  "\n + Часть Жизни = Карта Голиаф" +
									  "\n + Часть Огня = Карта Ядро" +
									  "\n + Часть Света = Карта Нирвана" +
									  "\n + Часть Смерти = Карта Порча"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 5:
					Console.Clear(); Console.WriteLine("Часть Огня:" +
									  "\n + Часть Воды = Карта Мгла" +
									  "\n + Часть Воздуха = Карта Пламенный Шквал" +
									  "\n + Часть Земля = Карта Ядро" +
									  "\n + Часть Жизни = Карта Огненный элементаль" +
									  "\n + Часть Света = Карта Священный огонь" +
									  "\n + Часть Смерти = Карта Призрачный гонщик" +
									  "\n + Часть Тьмы = Карта Чистилище"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 6:
					Console.Clear(); Console.WriteLine("Часть Свет:" +
									  "\n + Часть Воды = Карта Сияние" +
									  "\n + Часть Воздуха = Карта Меркурий" +
									  "\n + Часть Жизни = Карта Люцефер" +
									  "\n + Часть Земля = Карта Нирвана" +
									  "\n + Часть Огонь = Карта Священный огонь" +
									  "\n + Часть Смерти = Карта Жнец" +
									  "\n + Часть Тьмы = Карта Хаос"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 7:
					Console.Clear(); Console.WriteLine("Часть Смерть:" +
									  "\n + Часть Воды = Карта Согра" +
									  "\n + Часть Воздуха = Карта Смерч" +
									  "\n + Часть Жизни = Карта Агония" +
									  "\n + Часть Земли = Карта Порча" +
									  "\n + Часть Огоня = Карта Призрачный гонщик" +
									  "\n + Часть Света = Карта Жнец" +
									  "\n + Часть Тьмы = Карта Пожиратель ночи"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 8:
					Console.Clear(); Console.WriteLine("Часть Тьма:" +
									  "\n + Часть Воды = Карта Левиафан" +
									  "\n + Часть Воздуха = Карта Мерезин" +
									  "\n + Часть Жизни = Карта Дарккид" +
									  "\n + Часть Земли = Карта Рагнарек" +
									  "\n + Часть Огоня = Карта Чистилище" +
									  "\n + Часть Света = Карта Хаос" +
									  "\n + Часть Смерти = Карта Пожиратель ночи"); Console.Write("\nНажмите Enter для продолжения.."); Console.ReadKey(); List_of_cards(); break;
				case 0: Rules(); break;
				default: List_of_cards(); break;
			}
		}

		public static void Game()
		{
			Console.Clear();
			int[] mas = new int[8];
			int[] Player = new int[4];
			int[] PC = new int[4];
			byte sc = 0, ind = 1;
			Console.WriteLine("Производится раздача частей.");
			mas = Card_distribution();
			for (int i = 0; i < 8; i++)
			{
				if (i < 4)
					Player[i] = mas[i];
				else
				{
					PC[sc] = mas[i];
					sc++;
				}
			}
			Console.WriteLine("У Вас в руке:\n");
			for (int i = 0; i < 4; i++)
			{

				if (Player[i] == 1) { Console.WriteLine(" " + ind + ".Часть Воды;"); ind++; }
				if (Player[i] == 2) { Console.WriteLine(" " + ind + ".Часть Воздуха;"); ind++; }
				if (Player[i] == 3) { Console.WriteLine(" " + ind + ".Часть Жизни;"); ind++; }
				if (Player[i] == 4) { Console.WriteLine(" " + ind + ".Часть Земли;"); ind++; }
				if (Player[i] == 5) { Console.WriteLine(" " + ind + ".Часть Огня;"); ind++; }
				if (Player[i] == 6) { Console.WriteLine(" " + ind + ".Часть Свет;"); ind++; }
				if (Player[i] == 7) { Console.WriteLine(" " + ind + ".Часть Смерти;"); ind++; }
				if (Player[i] == 8) { Console.WriteLine(" " + ind + ".Часть Тьмы;"); ind++; }
			}
			Console.WriteLine("Соедините части:\nВыберите первую Часть > ");

			Console.ReadKey();
			Menu();
		}

		public static void Rules()
		{
			byte ind = 0;
			bool p = false;
			Console.Clear();
			Console.WriteLine("Это карточная игра. Карта состоит из двух частей.\n" +
						  "При старте игры у Вас будет четрые различные части.\n" +
						  "Комбинируя их вы должны одолеть противника!");
			Console.Write("\n1.Просмотреть составные части\n0.Вернуться в меню\n > ");
			ind = Convert.ToByte(Console.ReadLine());
			switch (ind)
			{
				case 1: p = true; break;
				case 0: Menu(); break;
				default: Rules(); break;
			}
			if (p == true)
			{
				Console.Clear();
				Console.WriteLine("1.Часть Воды" +
								  "\n2.Часть Воздуха" +
								  "\n3.Часть Жизни" +
								  "\n4.Часть Земли" +
								  "\n5.Часть Огня" +
								  "\n6.Часть Света" +
								  "\n7.Часть Смерти" +
								  "\n8.Часть Тьмы");
				Console.Write("\n\n1.Пройти обучение\n2.Просмотреть все карты\n3.Назак к правилам\n > ");
				ind = Convert.ToByte(Console.ReadLine());
			switch (ind)
			{
					case 1: Training(); break;
					case 2: List_of_cards(); break;
					case 3: Rules(); break;
					default: Rules(); break;
			}

			}
		}

		public static void Menu()
		{
			byte ind = 0;
			Console.Clear();
			Console.Write("1.Играть\n2.Прочесть правила\n3.Тренировка\n0.Выход\n > ");
			ind = Convert.ToByte(Console.ReadLine());
			switch (ind)
			{
				case 1: Game(); break;
				case 2: Rules(); break;
				case 3: Training(); break;
				case 0: break;
				default: Menu(); break;
			}

		}
		public static void Main(string[] args)
		{
			Menu();
		}
	}
}
