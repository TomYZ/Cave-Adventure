#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// GenericWindow[]
struct GenericWindowU5BU5D_t3046460798;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// WindowManager
struct  WindowManager_t3316821373  : public MonoBehaviour_t3012272455
{
public:
	// GenericWindow[] WindowManager::windows
	GenericWindowU5BU5D_t3046460798* ___windows_2;
	// System.Int32 WindowManager::currentWindowID
	int32_t ___currentWindowID_3;
	// System.Int32 WindowManager::defaultWindowID
	int32_t ___defaultWindowID_4;

public:
	inline static int32_t get_offset_of_windows_2() { return static_cast<int32_t>(offsetof(WindowManager_t3316821373, ___windows_2)); }
	inline GenericWindowU5BU5D_t3046460798* get_windows_2() const { return ___windows_2; }
	inline GenericWindowU5BU5D_t3046460798** get_address_of_windows_2() { return &___windows_2; }
	inline void set_windows_2(GenericWindowU5BU5D_t3046460798* value)
	{
		___windows_2 = value;
		Il2CppCodeGenWriteBarrier(&___windows_2, value);
	}

	inline static int32_t get_offset_of_currentWindowID_3() { return static_cast<int32_t>(offsetof(WindowManager_t3316821373, ___currentWindowID_3)); }
	inline int32_t get_currentWindowID_3() const { return ___currentWindowID_3; }
	inline int32_t* get_address_of_currentWindowID_3() { return &___currentWindowID_3; }
	inline void set_currentWindowID_3(int32_t value)
	{
		___currentWindowID_3 = value;
	}

	inline static int32_t get_offset_of_defaultWindowID_4() { return static_cast<int32_t>(offsetof(WindowManager_t3316821373, ___defaultWindowID_4)); }
	inline int32_t get_defaultWindowID_4() const { return ___defaultWindowID_4; }
	inline int32_t* get_address_of_defaultWindowID_4() { return &___defaultWindowID_4; }
	inline void set_defaultWindowID_4(int32_t value)
	{
		___defaultWindowID_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
