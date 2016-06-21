#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// WindowManager
struct WindowManager_t3316821373;
// UnityEngine.GameObject
struct GameObject_t4012695102;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// GenericWindow
struct  GenericWindow_t1006240903  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.GameObject GenericWindow::firstSelected
	GameObject_t4012695102 * ___firstSelected_3;

public:
	inline static int32_t get_offset_of_firstSelected_3() { return static_cast<int32_t>(offsetof(GenericWindow_t1006240903, ___firstSelected_3)); }
	inline GameObject_t4012695102 * get_firstSelected_3() const { return ___firstSelected_3; }
	inline GameObject_t4012695102 ** get_address_of_firstSelected_3() { return &___firstSelected_3; }
	inline void set_firstSelected_3(GameObject_t4012695102 * value)
	{
		___firstSelected_3 = value;
		Il2CppCodeGenWriteBarrier(&___firstSelected_3, value);
	}
};

struct GenericWindow_t1006240903_StaticFields
{
public:
	// WindowManager GenericWindow::manager
	WindowManager_t3316821373 * ___manager_2;

public:
	inline static int32_t get_offset_of_manager_2() { return static_cast<int32_t>(offsetof(GenericWindow_t1006240903_StaticFields, ___manager_2)); }
	inline WindowManager_t3316821373 * get_manager_2() const { return ___manager_2; }
	inline WindowManager_t3316821373 ** get_address_of_manager_2() { return &___manager_2; }
	inline void set_manager_2(WindowManager_t3316821373 * value)
	{
		___manager_2 = value;
		Il2CppCodeGenWriteBarrier(&___manager_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
