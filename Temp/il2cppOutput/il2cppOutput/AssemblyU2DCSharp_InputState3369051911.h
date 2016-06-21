#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Rigidbody2D
struct Rigidbody2D_t3632243084;
// System.Collections.Generic.Dictionary`2<Buttons,ButtonState>
struct Dictionary_2_t422194536;

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "AssemblyU2DCSharp_Directions2217919732.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// InputState
struct  InputState_t3369051911  : public MonoBehaviour_t3012272455
{
public:
	// Directions InputState::direction
	int32_t ___direction_2;
	// System.Single InputState::absVelX
	float ___absVelX_3;
	// System.Single InputState::absVelY
	float ___absVelY_4;
	// UnityEngine.Rigidbody2D InputState::body2d
	Rigidbody2D_t3632243084 * ___body2d_5;
	// System.Collections.Generic.Dictionary`2<Buttons,ButtonState> InputState::buttonStates
	Dictionary_2_t422194536 * ___buttonStates_6;

public:
	inline static int32_t get_offset_of_direction_2() { return static_cast<int32_t>(offsetof(InputState_t3369051911, ___direction_2)); }
	inline int32_t get_direction_2() const { return ___direction_2; }
	inline int32_t* get_address_of_direction_2() { return &___direction_2; }
	inline void set_direction_2(int32_t value)
	{
		___direction_2 = value;
	}

	inline static int32_t get_offset_of_absVelX_3() { return static_cast<int32_t>(offsetof(InputState_t3369051911, ___absVelX_3)); }
	inline float get_absVelX_3() const { return ___absVelX_3; }
	inline float* get_address_of_absVelX_3() { return &___absVelX_3; }
	inline void set_absVelX_3(float value)
	{
		___absVelX_3 = value;
	}

	inline static int32_t get_offset_of_absVelY_4() { return static_cast<int32_t>(offsetof(InputState_t3369051911, ___absVelY_4)); }
	inline float get_absVelY_4() const { return ___absVelY_4; }
	inline float* get_address_of_absVelY_4() { return &___absVelY_4; }
	inline void set_absVelY_4(float value)
	{
		___absVelY_4 = value;
	}

	inline static int32_t get_offset_of_body2d_5() { return static_cast<int32_t>(offsetof(InputState_t3369051911, ___body2d_5)); }
	inline Rigidbody2D_t3632243084 * get_body2d_5() const { return ___body2d_5; }
	inline Rigidbody2D_t3632243084 ** get_address_of_body2d_5() { return &___body2d_5; }
	inline void set_body2d_5(Rigidbody2D_t3632243084 * value)
	{
		___body2d_5 = value;
		Il2CppCodeGenWriteBarrier(&___body2d_5, value);
	}

	inline static int32_t get_offset_of_buttonStates_6() { return static_cast<int32_t>(offsetof(InputState_t3369051911, ___buttonStates_6)); }
	inline Dictionary_2_t422194536 * get_buttonStates_6() const { return ___buttonStates_6; }
	inline Dictionary_2_t422194536 ** get_address_of_buttonStates_6() { return &___buttonStates_6; }
	inline void set_buttonStates_6(Dictionary_2_t422194536 * value)
	{
		___buttonStates_6 = value;
		Il2CppCodeGenWriteBarrier(&___buttonStates_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
