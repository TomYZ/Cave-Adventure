#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// Buttons[]
struct ButtonsU5BU5D_t1843995132;
// UnityEngine.MonoBehaviour[]
struct MonoBehaviourU5BU5D_t936895934;
// InputState
struct InputState_t3369051911;
// UnityEngine.Rigidbody2D
struct Rigidbody2D_t3632243084;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AbstractBehavior
struct  AbstractBehavior_t320735412  : public MonoBehaviour_t3012272455
{
public:
	// Buttons[] AbstractBehavior::inputButtons
	ButtonsU5BU5D_t1843995132* ___inputButtons_2;
	// UnityEngine.MonoBehaviour[] AbstractBehavior::dissableScripts
	MonoBehaviourU5BU5D_t936895934* ___dissableScripts_3;
	// InputState AbstractBehavior::inputState
	InputState_t3369051911 * ___inputState_4;
	// UnityEngine.Rigidbody2D AbstractBehavior::body2d
	Rigidbody2D_t3632243084 * ___body2d_5;

public:
	inline static int32_t get_offset_of_inputButtons_2() { return static_cast<int32_t>(offsetof(AbstractBehavior_t320735412, ___inputButtons_2)); }
	inline ButtonsU5BU5D_t1843995132* get_inputButtons_2() const { return ___inputButtons_2; }
	inline ButtonsU5BU5D_t1843995132** get_address_of_inputButtons_2() { return &___inputButtons_2; }
	inline void set_inputButtons_2(ButtonsU5BU5D_t1843995132* value)
	{
		___inputButtons_2 = value;
		Il2CppCodeGenWriteBarrier(&___inputButtons_2, value);
	}

	inline static int32_t get_offset_of_dissableScripts_3() { return static_cast<int32_t>(offsetof(AbstractBehavior_t320735412, ___dissableScripts_3)); }
	inline MonoBehaviourU5BU5D_t936895934* get_dissableScripts_3() const { return ___dissableScripts_3; }
	inline MonoBehaviourU5BU5D_t936895934** get_address_of_dissableScripts_3() { return &___dissableScripts_3; }
	inline void set_dissableScripts_3(MonoBehaviourU5BU5D_t936895934* value)
	{
		___dissableScripts_3 = value;
		Il2CppCodeGenWriteBarrier(&___dissableScripts_3, value);
	}

	inline static int32_t get_offset_of_inputState_4() { return static_cast<int32_t>(offsetof(AbstractBehavior_t320735412, ___inputState_4)); }
	inline InputState_t3369051911 * get_inputState_4() const { return ___inputState_4; }
	inline InputState_t3369051911 ** get_address_of_inputState_4() { return &___inputState_4; }
	inline void set_inputState_4(InputState_t3369051911 * value)
	{
		___inputState_4 = value;
		Il2CppCodeGenWriteBarrier(&___inputState_4, value);
	}

	inline static int32_t get_offset_of_body2d_5() { return static_cast<int32_t>(offsetof(AbstractBehavior_t320735412, ___body2d_5)); }
	inline Rigidbody2D_t3632243084 * get_body2d_5() const { return ___body2d_5; }
	inline Rigidbody2D_t3632243084 ** get_address_of_body2d_5() { return &___body2d_5; }
	inline void set_body2d_5(Rigidbody2D_t3632243084 * value)
	{
		___body2d_5 = value;
		Il2CppCodeGenWriteBarrier(&___body2d_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
