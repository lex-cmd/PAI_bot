﻿using Telegram.Bot.Types;

namespace TelegramPAI
{
	internal class PaiBot : IBot //основной класс программы для работы с любым чатом
	{

		public PaiBot()
		{

		}

		public void NewMessageReceived() //метод для получения новой строки для обработки
		{

		}

		public void Start(Message newMessage) //запуск основной программы
		{
			if(newMessage == null)
				return;
		}

		public void Start() //запуск основной программы
		{

		}
		public void Start(string[] args) //запуск основной программы
		{

		}

		public void Stop() //остановка основной программы
		{

		}

		public void ResponseToChat() //метод для отправки сообщения
		{

		}

	}
}
