#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// InputAxisState[]
struct InputAxisStateU5BU5D_t982520003;
// InputState
struct InputState_t3369051911;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// InputManager
struct  InputManager_t1985948835  : public MonoBehaviour_t3012272455
{
public:
	// InputAxisState[] InputManager::inputs
	InputAxisStateU5BU5D_t982520003* ___inputs_2;
	// InputState InputManager::inputState
	InputState_t3369051911 * ___inputState_3;

public:
	inline static int32_t get_offset_of_inputs_2() { return static_cast<int32_t>(offsetof(InputManager_t1985948835, ___inputs_2)); }
	inline InputAxisStateU5BU5D_t982520003* get_inputs_2() const { return ___inputs_2; }
	inline InputAxisStateU5BU5D_t982520003** get_address_of_inputs_2() { return &___inputs_2; }
	inline void set_inputs_2(InputAxisStateU5BU5D_t982520003* value)
	{
		___inputs_2 = value;
		Il2CppCodeGenWriteBarrier(&___inputs_2, value);
	}

	inline static int32_t get_offset_of_inputState_3() { return static_cast<int32_t>(offsetof(InputManager_t1985948835, ___inputState_3)); }
	inline InputState_t3369051911 * get_inputState_3() const { return ___inputState_3; }
	inline InputState_t3369051911 ** get_address_of_inputState_3() { return &___inputState_3; }
	inline void set_inputState_3(InputState_t3369051911 * value)
	{
		___inputState_3 = value;
		Il2CppCodeGenWriteBarrier(&___inputState_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
