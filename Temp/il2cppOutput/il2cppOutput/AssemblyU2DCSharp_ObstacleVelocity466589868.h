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

// ObstacleVelocity
struct  ObstacleVelocity_t466589868  : public MonoBehaviour_t3012272455
{
public:
	// UnityEngine.Vector2 ObstacleVelocity::velocity
	Vector2_t3525329788  ___velocity_2;
	// UnityEngine.Rigidbody2D ObstacleVelocity::rb2d
	Rigidbody2D_t3632243084 * ___rb2d_3;

public:
	inline static int32_t get_offset_of_velocity_2() { return static_cast<int32_t>(offsetof(ObstacleVelocity_t466589868, ___velocity_2)); }
	inline Vector2_t3525329788  get_velocity_2() const { return ___velocity_2; }
	inline Vector2_t3525329788 * get_address_of_velocity_2() { return &___velocity_2; }
	inline void set_velocity_2(Vector2_t3525329788  value)
	{
		___velocity_2 = value;
	}

	inline static int32_t get_offset_of_rb2d_3() { return static_cast<int32_t>(offsetof(ObstacleVelocity_t466589868, ___rb2d_3)); }
	inline Rigidbody2D_t3632243084 * get_rb2d_3() const { return ___rb2d_3; }
	inline Rigidbody2D_t3632243084 ** get_address_of_rb2d_3() { return &___rb2d_3; }
	inline void set_rb2d_3(Rigidbody2D_t3632243084 * value)
	{
		___rb2d_3 = value;
		Il2CppCodeGenWriteBarrier(&___rb2d_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
