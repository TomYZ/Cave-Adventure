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

#include "UnityEngine_UnityEngine_MonoBehaviour3012272455.h"
#include "UnityEngine_UnityEngine_Vector23525329788.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Rocket
struct  Rocket_t2453156596  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Vector2 Rocket::initialVelocity
	Vector2_t3525329788  ___initialVelocity_2;
	// UnityEngine.Rigidbody2D Rocket::body2d
	Rigidbody2D_t3632243084 * ___body2d_3;
	// System.Single Rocket::last_position
	float ___last_position_4;

public:
	inline static int32_t get_offset_of_initialVelocity_2() { return static_cast<int32_t>(offsetof(Rocket_t2453156596, ___initialVelocity_2)); }
	inline Vector2_t3525329788  get_initialVelocity_2() const { return ___initialVelocity_2; }
	inline Vector2_t3525329788 * get_address_of_initialVelocity_2() { return &___initialVelocity_2; }
	inline void set_initialVelocity_2(Vector2_t3525329788  value)
	{
		___initialVelocity_2 = value;
	}

	inline static int32_t get_offset_of_body2d_3() { return static_cast<int32_t>(offsetof(Rocket_t2453156596, ___body2d_3)); }
	inline Rigidbody2D_t3632243084 * get_body2d_3() const { return ___body2d_3; }
	inline Rigidbody2D_t3632243084 ** get_address_of_body2d_3() { return &___body2d_3; }
	inline void set_body2d_3(Rigidbody2D_t3632243084 * value)
	{
		___body2d_3 = value;
		Il2CppCodeGenWriteBarrier(&___body2d_3, value);
	}

	inline static int32_t get_offset_of_last_position_4() { return static_cast<int32_t>(offsetof(Rocket_t2453156596, ___last_position_4)); }
	inline float get_last_position_4() const { return ___last_position_4; }
	inline float* get_address_of_last_position_4() { return &___last_position_4; }
	inline void set_last_position_4(float value)
	{
		___last_position_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
