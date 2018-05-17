#pragma once

#include <string>
#include <map>
#include <functional>
#include "Tasks/Tasks.hpp"
#include "Helpers/FormatString.hpp"
#include "IFile.hpp"
#include "ConfigKey.hpp"

namespace fl
{
	class FL_EXPORT Config
	{
	private:
		IFile *m_file;
		std::map<std::string, ConfigKey> *m_values;
	public:
#define CONFIG_GET(f) (new std::function<std::string()>([&]() -> std::string { return std::to_string(f); }))
#define CONFIG_SET(t, f) (new std::function<void(t)>([&](const t &v) -> void { f; }))

		Config(IFile *file);

		~Config();

		void Load();

		void Update();

		void Save();

		ConfigKey GetRaw(const std::string &key, const std::string &normal);

		void SetRaw(const std::string &key, const std::string &value);

		template<typename T>
		T Get(const std::string &key, const T &normal)
		{
			return FormatString::ConvertTo<T>(GetRaw(key, std::to_string(normal)).GetValue());
		}

		template<typename T>
		void Set(const std::string &key, const T &value)
		{
			SetRaw(key, std::to_string(value));
		}

		template<typename T>
		void Link(const std::string &key, const T &normal, std::function<std::string()> *getter, std::function<void(T)> *setter = nullptr)
		{
			ConfigKey configKey = GetRaw(key, std::to_string(normal));

			if (getter != nullptr)
			{
				configKey.SetGetter(getter);
			}

			if (setter != nullptr && configKey.IsFromFile())
			{
				(*setter)(Get(key, normal));
			}
		}
	};
}